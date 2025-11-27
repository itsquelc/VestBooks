using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestBooks.Data;
using VestBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace VestBooks.Controllers;

[Authorize(Roles = "Administrador")]
public class UsuariosController : Controller
{
    private readonly AppDbContext _context;
    private readonly UserManager<Usuario> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ILogger<UsuariosController> _logger;
    private readonly IWebHostEnvironment _environment;

    public UsuariosController(AppDbContext context, UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager, ILogger<UsuariosController> logger, IWebHostEnvironment environment)
    {
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
        _logger = logger;
        _environment = environment;
    }

    // GET: Usuarios
    public async Task<IActionResult> Index()
    {
        try
        {
            var usuarios = await _userManager.Users.ToListAsync();
            return View(usuarios);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar usuários");
            TempData["Erro"] = "Erro ao carregar usuários. Tente novamente.";
            return View(new List<Usuario>());
        }
    }

    // GET: Usuarios/Details/5
    public async Task<IActionResult> Details(string id)
    {
        try
        {
            var usuario = await _userManager.FindByIdAsync(id);
            if (usuario == null)
            {
                TempData["Erro"] = "Usuário não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            // Carregar roles do usuário
            var userRoles = await _userManager.GetRolesAsync(usuario);
            ViewBag.UserRoles = userRoles;

            return View(usuario);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar usuário {Id}", id);
            TempData["Erro"] = "Erro ao carregar usuário.";
            return RedirectToAction(nameof(Index));
        }
    }

    // GET: Usuarios/Create
    public async Task<IActionResult> Create()
    {
        // Carregar todas as roles disponíveis
        var roles = await _roleManager.Roles.ToListAsync();
        ViewBag.Roles = roles;
        return View();
    }

    // POST: Usuarios/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Usuario usuario, string password, IFormFile foto, List<string> selectedRoles)
    {
        if (!ModelState.IsValid)
        {
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = roles;
            return View(usuario);
        }

        try
        {
            // Verificar se email já existe
            var existingUser = await _userManager.FindByEmailAsync(usuario.Email);
            if (existingUser != null)
            {
                ModelState.AddModelError("Email", "Este email já está em uso.");
                var roles = await _roleManager.Roles.ToListAsync();
                ViewBag.Roles = roles;
                return View(usuario);
            }

            // Upload da foto
            if (foto != null && foto.Length > 0)
            {
                usuario.Foto = await SalvarFoto(foto);
            }

            usuario.UserName = usuario.Email; // Definir UserName como Email
            usuario.EmailConfirmed = true;

            var result = await _userManager.CreateAsync(usuario, password);

            if (result.Succeeded)
            {
                // Adicionar roles selecionadas
                if (selectedRoles != null && selectedRoles.Any())
                {
                    var addRolesResult = await _userManager.AddToRolesAsync(usuario, selectedRoles);
                    if (!addRolesResult.Succeeded)
                    {
                        // Se falhar ao adicionar roles, adicionar erros ao ModelState
                        foreach (var error in addRolesResult.Errors)
                        {
                            ModelState.AddModelError("", $"Erro ao adicionar role: {error.Description}");
                        }
                        
                        var roles = await _roleManager.Roles.ToListAsync();
                        ViewBag.Roles = roles;
                        return View(usuario);
                    }
                }

                TempData["Sucesso"] = "Usuário criado com sucesso!";
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            var allRoles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = allRoles;
            return View(usuario);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar usuário");
            ModelState.AddModelError("", "Erro interno ao criar usuário.");
            
            var roles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = roles;
            return View(usuario);
        }
    }

    // GET: Usuarios/Edit/5
    public async Task<IActionResult> Edit(string id)
    {
        try
        {
            var usuario = await _userManager.FindByIdAsync(id);
            if (usuario == null)
            {
                TempData["Erro"] = "Usuário não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            // Carregar roles do usuário
            var userRoles = await _userManager.GetRolesAsync(usuario);
            
            // Carregar todas as roles disponíveis
            var allRoles = await _roleManager.Roles.ToListAsync();
            
            ViewBag.Roles = allRoles;
            ViewBag.UserRoles = userRoles;

            return View(usuario);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar usuário para edição {Id}", id);
            TempData["Erro"] = "Erro ao carregar usuário.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Usuarios/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(string id, Usuario usuario, IFormFile foto, List<string> selectedRoles)
    {
        if (id != usuario.Id)
        {
            TempData["Erro"] = "Usuário inválido.";
            return RedirectToAction(nameof(Index));
        }

        if (!ModelState.IsValid)
        {
            var allRoles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = allRoles;
            ViewBag.UserRoles = selectedRoles ?? new List<string>();
            return View(usuario);
        }

        try
        {
            var usuarioExistente = await _userManager.FindByIdAsync(id);
            if (usuarioExistente == null)
            {
                TempData["Erro"] = "Usuário não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            // Verificar se email já existe (excluindo o usuário atual)
            var existingUser = await _userManager.FindByEmailAsync(usuario.Email);
            if (existingUser != null && existingUser.Id != id)
            {
                ModelState.AddModelError("Email", "Este email já está em uso.");
                var allRoles = await _roleManager.Roles.ToListAsync();
                ViewBag.Roles = allRoles;
                ViewBag.UserRoles = selectedRoles ?? new List<string>();
                return View(usuario);
            }

            // Upload da nova foto se fornecida
            if (foto != null && foto.Length > 0)
            {
                // Deletar foto antiga se existir
                if (!string.IsNullOrEmpty(usuarioExistente.Foto))
                {
                    DeletarFoto(usuarioExistente.Foto);
                }
                usuarioExistente.Foto = await SalvarFoto(foto);
            }

            // Atualizar outros campos
            usuarioExistente.Nome = usuario.Nome;
            usuarioExistente.Email = usuario.Email;
            usuarioExistente.UserName = usuario.Email;
            usuarioExistente.PhoneNumber = usuario.PhoneNumber;
            usuarioExistente.DataNascimento = usuario.DataNascimento;

            var result = await _userManager.UpdateAsync(usuarioExistente);

            if (result.Succeeded)
            {
                // Atualizar roles
                if (selectedRoles != null)
                {
                    // Obter roles atuais do usuário
                    var currentRoles = await _userManager.GetRolesAsync(usuarioExistente);
                    
                    // Remover roles que não estão mais selecionadas
                    var rolesToRemove = currentRoles.Except(selectedRoles).ToList();
                    if (rolesToRemove.Any())
                    {
                        await _userManager.RemoveFromRolesAsync(usuarioExistente, rolesToRemove);
                    }
                    
                    // Adicionar novas roles
                    var rolesToAdd = selectedRoles.Except(currentRoles).ToList();
                    if (rolesToAdd.Any())
                    {
                        await _userManager.AddToRolesAsync(usuarioExistente, rolesToAdd);
                    }
                }
                else
                {
                    // Se nenhuma role foi selecionada, remover todas as roles
                    var currentRoles = await _userManager.GetRolesAsync(usuarioExistente);
                    if (currentRoles.Any())
                    {
                        await _userManager.RemoveFromRolesAsync(usuarioExistente, currentRoles);
                    }
                }

                TempData["Sucesso"] = "Usuário atualizado com sucesso!";
                return RedirectToAction(nameof(Index));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            var allRolesView = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = allRolesView;
            ViewBag.UserRoles = selectedRoles ?? new List<string>();
            return View(usuario);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar usuário {Id}", id);
            ModelState.AddModelError("", "Erro interno ao atualizar usuário.");
            
            var allRoles = await _roleManager.Roles.ToListAsync();
            ViewBag.Roles = allRoles;
            ViewBag.UserRoles = selectedRoles ?? new List<string>();
            return View(usuario);
        }
    }

    // ... (os outros métodos Delete, ResetPassword, etc. permanecem iguais) ...

    // Métodos auxiliares para upload de fotos (permanecem iguais)
    private async Task<string> SalvarFoto(IFormFile foto)
    {
        // Criar diretório se não existir
        var uploadsPath = Path.Combine(_environment.WebRootPath, "img", "usuarios");
        if (!Directory.Exists(uploadsPath))
            Directory.CreateDirectory(uploadsPath);

        // Gerar nome único para o arquivo
        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(foto.FileName);
        var filePath = Path.Combine(uploadsPath, fileName);

        // Salvar arquivo
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await foto.CopyToAsync(stream);
        }

        // Retornar caminho relativo para salvar no banco
        return $"/img/usuarios/{fileName}";
    }

    private void DeletarFoto(string fotoPath)
    {
        if (string.IsNullOrEmpty(fotoPath))
            return;

        var fullPath = Path.Combine(_environment.WebRootPath, fotoPath.TrimStart('/'));
        if (System.IO.File.Exists(fullPath))
        {
            System.IO.File.Delete(fullPath);
        }
    }
}