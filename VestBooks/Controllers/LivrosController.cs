using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestBooks.Data;
using VestBooks.Models;
using Microsoft.AspNetCore.Authorization;

namespace VestBooks.Controllers;

// [Authorize(Roles = "Administrador")]
public class LivrosController : Controller
{
    private readonly AppDbContext _context;
    private readonly ILogger<LivrosController> _logger;
    private readonly IWebHostEnvironment _environment;

    public LivrosController(AppDbContext context, ILogger<LivrosController> logger, IWebHostEnvironment environment)
    {
        _context = context;
        _logger = logger;
        _environment = environment;
    }

    // GET: Livros
    public async Task<IActionResult> Index()
    {
        try
        {
            var livros = await _context.Livros
                .Include(l => l.Autor)
                .Include(l => l.Faculdades)
                    .ThenInclude(fl => fl.Faculdade)
                .AsNoTracking()
                .ToListAsync();
            return View(livros);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar livros");
            TempData["Erro"] = "Erro ao carregar livros. Tente novamente.";
            return View(new List<Livro>());
        }
    }

    // GET: Livros/Details/5
    public async Task<IActionResult> Details(int id)
    {
        try
        {
            var livro = await _context.Livros
                .Include(l => l.Autor)
                .Include(l => l.Faculdades)
                    .ThenInclude(fl => fl.Faculdade)
                .AsNoTracking()
                .FirstOrDefaultAsync(l => l.LivroId == id);
                
            if (livro == null)
            {
                TempData["Erro"] = "Livro não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            return View(livro);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar livro {Id}", id);
            TempData["Erro"] = "Erro ao carregar livro.";
            return RedirectToAction(nameof(Index));
        }
    }

    // GET: Livros/Create
    public async Task<IActionResult> Create()
    {
        try
        {
            ViewBag.Autores = await _context.Autores.AsNoTracking().ToListAsync();
            ViewBag.Faculdades = await _context.Faculdades.AsNoTracking().ToListAsync();
            return View();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar dados para criar livro");
            TempData["Erro"] = "Erro ao carregar dados.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Livros/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Livro livro, IFormFile foto, IFormFile pdf, List<int> FaculdadeIds)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Autores = await _context.Autores.AsNoTracking().ToListAsync();
            ViewBag.Faculdades = await _context.Faculdades.AsNoTracking().ToListAsync();
            return View(livro);
        }

        try
        {
            // Upload da foto
            if (foto != null && foto.Length > 0)
            {
                livro.Foto = await SalvarFoto(foto);
            }

            // Upload do PDF
            if (pdf != null && pdf.Length > 0)
            {
                livro.Pdf = await SalvarPdf(pdf);
            }

            // Adicionar o livro primeiro
            _context.Livros.Add(livro);
            await _context.SaveChangesAsync();

            // Adicionar as faculdades relacionadas
            if (FaculdadeIds != null && FaculdadeIds.Any())
            {
                foreach (var faculdadeId in FaculdadeIds)
                {
                    var faculdadeLivro = new FaculdadeLivro
                    {
                        LivroId = livro.LivroId,
                        FaculdadeId = faculdadeId
                    };
                    _context.FaculdadeLivros.Add(faculdadeLivro);
                }
                await _context.SaveChangesAsync();
            }

            TempData["Sucesso"] = "Livro criado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar livro");
            ViewBag.Autores = await _context.Autores.AsNoTracking().ToListAsync();
            ViewBag.Faculdades = await _context.Faculdades.AsNoTracking().ToListAsync();
            ModelState.AddModelError("", "Erro interno ao criar livro.");
            return View(livro);
        }
    }

    // GET: Livros/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        try
        {
            var livro = await _context.Livros
                .Include(l => l.Faculdades)
                .AsNoTracking()
                .FirstOrDefaultAsync(l => l.LivroId == id);
                
            if (livro == null)
            {
                TempData["Erro"] = "Livro não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Autores = await _context.Autores.AsNoTracking().ToListAsync();
            ViewBag.Faculdades = await _context.Faculdades.AsNoTracking().ToListAsync();
            ViewBag.FaculdadesSelecionadas = livro.Faculdades?.Select(fl => fl.FaculdadeId).ToList() ?? new List<int>();
            
            return View(livro);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar livro para edição {Id}", id);
            TempData["Erro"] = "Erro ao carregar livro.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Livros/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Livro livro, IFormFile foto, IFormFile pdf, List<int> FaculdadeIds)
    {
        if (id != livro.LivroId)
        {
            TempData["Erro"] = "Livro inválido.";
            return RedirectToAction(nameof(Index));
        }

        if (!ModelState.IsValid)
        {
            ViewBag.Autores = await _context.Autores.AsNoTracking().ToListAsync();
            ViewBag.Faculdades = await _context.Faculdades.AsNoTracking().ToListAsync();
            ViewBag.FaculdadesSelecionadas = FaculdadeIds ?? new List<int>();
            return View(livro);
        }

        try
        {
            var livroExistente = await _context.Livros
                .Include(l => l.Faculdades)
                .FirstOrDefaultAsync(l => l.LivroId == id);
                
            if (livroExistente == null)
            {
                TempData["Erro"] = "Livro não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            // Upload da nova foto se fornecida
            if (foto != null && foto.Length > 0)
            {
                // Deletar foto antiga se existir
                if (!string.IsNullOrEmpty(livroExistente.Foto))
                {
                    DeletarArquivo(livroExistente.Foto);
                }
                livroExistente.Foto = await SalvarFoto(foto);
            }

            // Upload do novo PDF se fornecido
            if (pdf != null && pdf.Length > 0)
            {
                // Deletar PDF antigo se existir
                if (!string.IsNullOrEmpty(livroExistente.Pdf))
                {
                    DeletarArquivo(livroExistente.Pdf);
                }
                livroExistente.Pdf = await SalvarPdf(pdf);
            }

            // Atualizar outros campos
            livroExistente.AutorId = livro.AutorId;
            livroExistente.Nome = livro.Nome;
            livroExistente.Descricao = livro.Descricao;
            livroExistente.Publicacao = livro.Publicacao;
            livroExistente.Avaliacao = livro.Avaliacao;
            livroExistente.NumeroPaginas = livro.NumeroPaginas;
            livroExistente.Resumo = livro.Resumo;
            livroExistente.Destaque = livro.Destaque;
            livroExistente.Video = livro.Video;

            // Atualizar faculdades relacionadas
            if (FaculdadeIds != null)
            {
                // Remover faculdades existentes
                var faculdadesExistentes = _context.FaculdadeLivros.Where(fl => fl.LivroId == id);
                _context.FaculdadeLivros.RemoveRange(faculdadesExistentes);
                await _context.SaveChangesAsync();

                // Adicionar novas faculdades
                foreach (var faculdadeId in FaculdadeIds)
                {
                    var faculdadeLivro = new FaculdadeLivro
                    {
                        LivroId = id,
                        FaculdadeId = faculdadeId
                    };
                    _context.FaculdadeLivros.Add(faculdadeLivro);
                }
                await _context.SaveChangesAsync();
            }

            _context.Livros.Update(livroExistente);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Livro atualizado com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar livro {Id}", id);
            ViewBag.Autores = await _context.Autores.AsNoTracking().ToListAsync();
            ViewBag.Faculdades = await _context.Faculdades.AsNoTracking().ToListAsync();
            ViewBag.FaculdadesSelecionadas = FaculdadeIds ?? new List<int>();
            ModelState.AddModelError("", "Erro interno ao atualizar livro.");
            return View(livro);
        }
    }

    // GET: Livros/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var livro = await _context.Livros
                .Include(l => l.Autor)
                .Include(l => l.Faculdades)
                    .ThenInclude(fl => fl.Faculdade)
                .AsNoTracking()
                .FirstOrDefaultAsync(l => l.LivroId == id);
                
            if (livro == null)
            {
                TempData["Erro"] = "Livro não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            return View(livro);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar livro para exclusão {Id}", id);
            TempData["Erro"] = "Erro ao carregar livro.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Livros/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        try
        {
            var livro = await _context.Livros
                .Include(l => l.Faculdades)
                .FirstOrDefaultAsync(l => l.LivroId == id);
                
            if (livro == null)
            {
                TempData["Erro"] = "Livro não encontrado.";
                return RedirectToAction(nameof(Index));
            }

            // Deletar relacionamentos com faculdades primeiro
            var faculdadesLivro = _context.FaculdadeLivros.Where(fl => fl.LivroId == id);
            _context.FaculdadeLivros.RemoveRange(faculdadesLivro);

            // Deletar arquivos se existirem
            if (!string.IsNullOrEmpty(livro.Foto))
            {
                DeletarArquivo(livro.Foto);
            }
            if (!string.IsNullOrEmpty(livro.Pdf))
            {
                DeletarArquivo(livro.Pdf);
            }

            // Deletar o livro
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Livro excluído com sucesso!";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao excluir livro {Id}", id);
            TempData["Erro"] = "Erro interno ao excluir livro.";
        }

        return RedirectToAction(nameof(Index));
    }

    // Métodos auxiliares para upload de arquivos
    private async Task<string> SalvarFoto(IFormFile foto)
    {
        return await SalvarArquivo(foto, "img", "livros");
    }

    private async Task<string> SalvarPdf(IFormFile pdf)
    {
        return await SalvarArquivo(pdf, "pdf", "livros");
    }

    private async Task<string> SalvarArquivo(IFormFile arquivo, string pasta, string subpasta)
    {
        // Criar diretório se não existir
        var uploadsPath = Path.Combine(_environment.WebRootPath, pasta, subpasta);
        if (!Directory.Exists(uploadsPath))
            Directory.CreateDirectory(uploadsPath);

        // Gerar nome único para o arquivo
        var fileName = Guid.NewGuid().ToString() + Path.GetExtension(arquivo.FileName);
        var filePath = Path.Combine(uploadsPath, fileName);

        // Salvar arquivo
        using (var stream = new FileStream(filePath, FileMode.Create))
        {
            await arquivo.CopyToAsync(stream);
        }

        // Retornar caminho relativo para salvar no banco
        return $"/{pasta}/{fileName}";
    }

    private void DeletarArquivo(string arquivoPath)
    {
        if (string.IsNullOrEmpty(arquivoPath))
            return;

        var fullPath = Path.Combine(_environment.WebRootPath, arquivoPath.TrimStart('/'));
        if (System.IO.File.Exists(fullPath))
        {
            System.IO.File.Delete(fullPath);
        }
    }
}