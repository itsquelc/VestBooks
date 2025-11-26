using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestBooks.Data;
using VestBooks.Models;
using Microsoft.AspNetCore.Authorization;

namespace VestBooks.Controllers;

[Authorize(Roles = "Administrador")]
public class FaculdadesController : Controller
{
    private readonly AppDbContext _context;
    private readonly ILogger<FaculdadesController> _logger;
    private readonly IWebHostEnvironment _environment;

    public FaculdadesController(AppDbContext context, ILogger<FaculdadesController> logger, IWebHostEnvironment environment)
    {
        _context = context;
        _logger = logger;
        _environment = environment;
    }

    // GET: Faculdades
    public async Task<IActionResult> Index()
    {
        try
        {
            var faculdades = await _context.Faculdades.ToListAsync();
            return View(faculdades);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar faculdades");
            TempData["Erro"] = "Erro ao carregar faculdades. Tente novamente.";
            return View(new List<Faculdade>());
        }
    }

    // GET: Faculdades/Details/5
    public async Task<IActionResult> Details(int id)
    {
        try
        {
            var faculdade = await _context.Faculdades.FindAsync(id);
            if (faculdade == null)
            {
                TempData["Erro"] = "Faculdade não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            return View(faculdade);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar faculdade {Id}", id);
            TempData["Erro"] = "Erro ao carregar faculdade.";
            return RedirectToAction(nameof(Index));
        }
    }

    // GET: Faculdades/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Faculdades/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Faculdade faculdade, IFormFile foto)
    {
        if (!ModelState.IsValid)
            return View(faculdade);

        try
        {
            // Upload da foto
            if (foto != null && foto.Length > 0)
            {
                faculdade.Foto = await SalvarFoto(foto);
            }

            _context.Faculdades.Add(faculdade);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Faculdade criada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar faculdade");
            ModelState.AddModelError("", "Erro interno ao criar faculdade.");
            return View(faculdade);
        }
    }

    // GET: Faculdades/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        try
        {
            var faculdade = await _context.Faculdades.FindAsync(id);
            if (faculdade == null)
            {
                TempData["Erro"] = "Faculdade não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            return View(faculdade);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar faculdade para edição {Id}", id);
            TempData["Erro"] = "Erro ao carregar faculdade.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Faculdades/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Faculdade faculdade, IFormFile foto)
    {
        if (id != faculdade.Id)
        {
            TempData["Erro"] = "Faculdade inválida.";
            return RedirectToAction(nameof(Index));
        }

        if (!ModelState.IsValid)
            return View(faculdade);

        try
        {
            var faculdadeExistente = await _context.Faculdades.FindAsync(id);
            if (faculdadeExistente == null)
            {
                TempData["Erro"] = "Faculdade não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            // Upload da nova foto se fornecida
            if (foto != null && foto.Length > 0)
            {
                // Deletar foto antiga se existir
                if (!string.IsNullOrEmpty(faculdadeExistente.Foto))
                {
                    DeletarFoto(faculdadeExistente.Foto);
                }
                faculdadeExistente.Foto = await SalvarFoto(foto);
            }

            // Atualizar outros campos
            faculdadeExistente.Nome = faculdade.Nome;
            faculdadeExistente.Descricao = faculdade.Descricao;

            _context.Faculdades.Update(faculdadeExistente);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Faculdade atualizada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar faculdade {Id}", id);
            ModelState.AddModelError("", "Erro interno ao atualizar faculdade.");
            return View(faculdade);
        }
    }

    // GET: Faculdades/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var faculdade = await _context.Faculdades.FindAsync(id);
            if (faculdade == null)
            {
                TempData["Erro"] = "Faculdade não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            return View(faculdade);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar faculdade para exclusão {Id}", id);
            TempData["Erro"] = "Erro ao carregar faculdade.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Faculdades/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        try
        {
            var faculdade = await _context.Faculdades.FindAsync(id);
            if (faculdade == null)
            {
                TempData["Erro"] = "Faculdade não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            // Deletar foto se existir
            if (!string.IsNullOrEmpty(faculdade.Foto))
            {
                DeletarFoto(faculdade.Foto);
            }

            _context.Faculdades.Remove(faculdade);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Faculdade excluída com sucesso!";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao excluir faculdade {Id}", id);
            TempData["Erro"] = "Erro interno ao excluir faculdade.";
        }

        return RedirectToAction(nameof(Index));
    }

    // Métodos auxiliares para upload de fotos
    private async Task<string> SalvarFoto(IFormFile foto)
    {
        // Criar diretório se não existir
        var uploadsPath = Path.Combine(_environment.WebRootPath, "img", "faculdades");
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
        return $"/img/faculdades/{fileName}";
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