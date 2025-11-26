using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestBooks.Data;
using VestBooks.Models;
using Microsoft.AspNetCore.Authorization;

namespace VestBooks.Controllers;

[Authorize(Roles = "Administrador")]
public class AutoresController : Controller
{
    private readonly AppDbContext _context;
    private readonly ILogger<AutoresController> _logger;
    private readonly IWebHostEnvironment _environment;

    public AutoresController(AppDbContext context, ILogger<AutoresController> logger, IWebHostEnvironment environment)
    {
        _context = context;
        _logger = logger;
        _environment = environment;
    }

    // GET: Autores
    public async Task<IActionResult> Index()
    {
        try
        {
            var autores = await _context.Autores.ToListAsync();
            return View(autores);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar autores");
            TempData["Erro"] = "Erro ao carregar autores. Tente novamente.";
            return View(new List<Autor>());
        }
    }

    // GET: Autores/Details/5
    public async Task<IActionResult> Details(int id)
    {
        try
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor == null)
            {
                TempData["Erro"] = "Autor não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            return View(autor);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar autor {Id}", id);
            TempData["Erro"] = "Erro ao carregar autor.";
            return RedirectToAction(nameof(Index));
        }
    }

    // GET: Autores/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Autores/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Autor autor, IFormFile foto)
    {
        if (!ModelState.IsValid)
            return View(autor);

        try
        {
            // Upload da foto
            if (foto != null && foto.Length > 0)
            {
                autor.Foto = await SalvarFoto(foto);
            }

            _context.Autores.Add(autor);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Autor criado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar autor");
            ModelState.AddModelError("", "Erro interno ao criar autor.");
            return View(autor);
        }
    }

    // GET: Autores/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        try
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor == null)
            {
                TempData["Erro"] = "Autor não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            return View(autor);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar autor para edição {Id}", id);
            TempData["Erro"] = "Erro ao carregar autor.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Autores/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Autor autor, IFormFile foto)
    {
        if (id != autor.AutorId)
        {
            TempData["Erro"] = "Autor inválido.";
            return RedirectToAction(nameof(Index));
        }

        if (!ModelState.IsValid)
            return View(autor);

        try
        {
            var autorExistente = await _context.Autores.FindAsync(id);
            if (autorExistente == null)
            {
                TempData["Erro"] = "Autor não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            // Upload da nova foto se fornecida
            if (foto != null && foto.Length > 0)
            {
                // Deletar foto antiga se existir
                if (!string.IsNullOrEmpty(autorExistente.Foto))
                {
                    DeletarFoto(autorExistente.Foto);
                }
                autorExistente.Foto = await SalvarFoto(foto);
            }

            // Atualizar outros campos
            autorExistente.Nome = autor.Nome;
            autorExistente.Biografia = autor.Biografia;

            _context.Autores.Update(autorExistente);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Autor atualizado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar autor {Id}", id);
            ModelState.AddModelError("", "Erro interno ao atualizar autor.");
            return View(autor);
        }
    }

    // GET: Autores/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor == null)
            {
                TempData["Erro"] = "Autor não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            return View(autor);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar autor para exclusão {Id}", id);
            TempData["Erro"] = "Erro ao carregar autor.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Autores/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        try
        {
            var autor = await _context.Autores.FindAsync(id);
            if (autor == null)
            {
                TempData["Erro"] = "Autor não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            // Verificar se o autor tem livros associados
            var livrosDoAutor = await _context.Livros.AnyAsync(l => l.AutorId == id);
            if (livrosDoAutor)
            {
                TempData["Erro"] = "Não é possível excluir o autor pois existem livros associados a ele.";
                return RedirectToAction(nameof(Index));
            }

            // Deletar foto se existir
            if (!string.IsNullOrEmpty(autor.Foto))
            {
                DeletarFoto(autor.Foto);
            }

            _context.Autores.Remove(autor);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Autor excluído com sucesso!";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao excluir autor {Id}", id);
            TempData["Erro"] = "Erro interno ao excluir autor.";
        }

        return RedirectToAction(nameof(Index));
    }

    // Métodos auxiliares para upload de fotos
    private async Task<string> SalvarFoto(IFormFile foto)
    {
        // Criar diretório se não existir
        var uploadsPath = Path.Combine(_environment.WebRootPath, "img", "autores");
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
        return $"/img/autores/{fileName}";
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