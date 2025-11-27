using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestBooks.Data;
using VestBooks.Models;
using Microsoft.AspNetCore.Authorization;

namespace VestBooks.Controllers;

// [Authorize(Roles = "Administrador")]
public class PerguntasController : Controller
{
    private readonly AppDbContext _context;
    private readonly ILogger<PerguntasController> _logger;

    public PerguntasController(AppDbContext context, ILogger<PerguntasController> logger)
    {
        _context = context;
        _logger = logger;
    }

    // GET: Perguntas
    public async Task<IActionResult> Index()
    {
        try
        {
            var perguntas = await _context.Perguntas
                .Include(p => p.Faculdade)
                .Include(p => p.PerguntaAlternativas)
                .ToListAsync();
            return View(perguntas);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar perguntas");
            TempData["Erro"] = "Erro ao carregar perguntas. Tente novamente.";
            return View(new List<Pergunta>());
        }
    }

    // GET: Perguntas/Details/5
    public async Task<IActionResult> Details(int id)
    {
        try
        {
            var pergunta = await _context.Perguntas
                .Include(p => p.Faculdade)
                .Include(p => p.PerguntaAlternativas)
                .FirstOrDefaultAsync(p => p.PerguntaId == id);
                
            if (pergunta == null)
            {
                TempData["Erro"] = "Pergunta não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            return View(pergunta);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar pergunta {Id}", id);
            TempData["Erro"] = "Erro ao carregar pergunta.";
            return RedirectToAction(nameof(Index));
        }
    }

    // GET: Perguntas/Create
    public async Task<IActionResult> Create()
    {
        try
        {
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar dados para criar pergunta");
            TempData["Erro"] = "Erro ao carregar dados.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Perguntas/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Pergunta pergunta, List<string> Alternativas, int AlternativaCorreta)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View(pergunta);
        }

        // Validar alternativas
        if (Alternativas == null || Alternativas.Count < 2)
        {
            ModelState.AddModelError("", "É necessário pelo menos 2 alternativas.");
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View(pergunta);
        }

        if (AlternativaCorreta < 0 || AlternativaCorreta >= Alternativas.Count)
        {
            ModelState.AddModelError("", "Alternativa correta inválida.");
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View(pergunta);
        }

        try
        {
            // Preservar quebras de linha no enunciado
            if (!string.IsNullOrEmpty(pergunta.Enunciado))
            {
                pergunta.Enunciado = pergunta.Enunciado.Replace("\r\n", "\n").Replace("\n", "<br>");
            }

            // Criar a pergunta
            _context.Perguntas.Add(pergunta);
            await _context.SaveChangesAsync();

            // Criar as alternativas
            for (int i = 0; i < Alternativas.Count; i++)
            {
                var alternativa = new PerguntaAlternativa
                {
                    PerguntaId = pergunta.PerguntaId,
                    Descricao = Alternativas[i].Replace("\r\n", "\n").Replace("\n", "<br>"),
                    Correta = (i == AlternativaCorreta)
                };
                _context.PerguntaAlternativas.Add(alternativa);
            }

            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Pergunta criada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar pergunta");
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            ModelState.AddModelError("", "Erro interno ao criar pergunta.");
            return View(pergunta);
        }
    }

    // GET: Perguntas/Edit/5
    public async Task<IActionResult> Edit(int id)
    {
        try
        {
            var pergunta = await _context.Perguntas
                .Include(p => p.PerguntaAlternativas)
                .FirstOrDefaultAsync(p => p.PerguntaId == id);
                
            if (pergunta == null)
            {
                TempData["Erro"] = "Pergunta não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View(pergunta);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar pergunta para edição {Id}", id);
            TempData["Erro"] = "Erro ao carregar pergunta.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Perguntas/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, Pergunta pergunta, List<string> Alternativas, int AlternativaCorreta)
    {
        if (id != pergunta.PerguntaId)
        {
            TempData["Erro"] = "Pergunta inválida.";
            return RedirectToAction(nameof(Index));
        }

        if (!ModelState.IsValid)
        {
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View(pergunta);
        }

        // Validar alternativas
        if (Alternativas == null || Alternativas.Count < 2)
        {
            ModelState.AddModelError("", "É necessário pelo menos 2 alternativas.");
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View(pergunta);
        }

        if (AlternativaCorreta < 0 || AlternativaCorreta >= Alternativas.Count)
        {
            ModelState.AddModelError("", "Alternativa correta inválida.");
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            return View(pergunta);
        }

        try
        {
            var perguntaExistente = await _context.Perguntas
                .Include(p => p.PerguntaAlternativas)
                .FirstOrDefaultAsync(p => p.PerguntaId == id);
                
            if (perguntaExistente == null)
            {
                TempData["Erro"] = "Pergunta não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            // Preservar quebras de linha no enunciado
            if (!string.IsNullOrEmpty(pergunta.Enunciado))
            {
                perguntaExistente.Enunciado = pergunta.Enunciado.Replace("\r\n", "\n").Replace("\n", "<br>");
            }

            perguntaExistente.FaculdadeId = pergunta.FaculdadeId;

            // Remover alternativas existentes
            _context.PerguntaAlternativas.RemoveRange(perguntaExistente.PerguntaAlternativas);

            // Adicionar novas alternativas
            for (int i = 0; i < Alternativas.Count; i++)
            {
                var alternativa = new PerguntaAlternativa
                {
                    PerguntaId = perguntaExistente.PerguntaId,
                    Descricao = Alternativas[i].Replace("\r\n", "\n").Replace("\n", "<br>"),
                    Correta = (i == AlternativaCorreta)
                };
                _context.PerguntaAlternativas.Add(alternativa);
            }

            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Pergunta atualizada com sucesso!";
            return RedirectToAction(nameof(Index));
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar pergunta {Id}", id);
            ViewBag.Faculdades = await _context.Faculdades.ToListAsync();
            ModelState.AddModelError("", "Erro interno ao atualizar pergunta.");
            return View(pergunta);
        }
    }

    // GET: Perguntas/Delete/5
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var pergunta = await _context.Perguntas
                .Include(p => p.Faculdade)
                .Include(p => p.PerguntaAlternativas)
                .FirstOrDefaultAsync(p => p.PerguntaId == id);
                
            if (pergunta == null)
            {
                TempData["Erro"] = "Pergunta não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            return View(pergunta);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar pergunta para exclusão {Id}", id);
            TempData["Erro"] = "Erro ao carregar pergunta.";
            return RedirectToAction(nameof(Index));
        }
    }

    // POST: Perguntas/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        try
        {
            var pergunta = await _context.Perguntas
                .Include(p => p.PerguntaAlternativas)
                .FirstOrDefaultAsync(p => p.PerguntaId == id);
                
            if (pergunta == null)
            {
                TempData["Erro"] = "Pergunta não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            // As alternativas serão deletadas em cascata devido ao relacionamento
            _context.Perguntas.Remove(pergunta);
            await _context.SaveChangesAsync();

            TempData["Sucesso"] = "Pergunta excluída com sucesso!";
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao excluir pergunta {Id}", id);
            TempData["Erro"] = "Erro interno ao excluir pergunta.";
        }

        return RedirectToAction(nameof(Index));
    }
}