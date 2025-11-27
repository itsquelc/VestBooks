using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestBooks.Data;
using VestBooks.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace VestBooks.Controllers;

[Authorize]
public class FavoritosController : Controller
{
    private readonly AppDbContext _context;
    private readonly UserManager<Usuario> _userManager;
    private readonly ILogger<FavoritosController> _logger;

    public FavoritosController(AppDbContext context, UserManager<Usuario> userManager, ILogger<FavoritosController> logger)
    {
        _context = context;
        _userManager = userManager;
        _logger = logger;
    }

    // GET: Favoritos/MeusFavoritos
    public async Task<IActionResult> MeusFavoritos()
    {
        try
        {
            var usuario = await _userManager.GetUserAsync(User);
            if (usuario == null)
            {
                return RedirectToAction("Login", "Account");
            }

            var favoritos = await _context.Favoritos
                .Where(f => f.UsuarioId == usuario.Id)
                .Include(f => f.Livro)
                    .ThenInclude(l => l.Autor)
                .Include(f => f.Livro)
                    .ThenInclude(l => l.Faculdades)
                        .ThenInclude(fl => fl.Faculdade)
                .OrderByDescending(f => f.DataFavoritado)
                .ToListAsync();

            return View(favoritos);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao carregar favoritos do usuário");
            TempData["Erro"] = "Erro ao carregar seus favoritos.";
            return View(new List<Favorito>());
        }
    }

    // POST: Favoritos/AdicionarFavorito/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AdicionarFavorito(int livroId)
    {
        try
        {
            var usuario = await _userManager.GetUserAsync(User);
            if (usuario == null)
            {
                return Json(new { success = false, message = "Usuário não autenticado." });
            }

            // Verificar se o livro existe
            var livro = await _context.Livros.FindAsync(livroId);
            if (livro == null)
            {
                return Json(new { success = false, message = "Livro não encontrado." });
            }

            // Verificar se já é favorito
            var jaFavoritado = await _context.Favoritos
                .AnyAsync(f => f.UsuarioId == usuario.Id && f.LivroId == livroId);

            if (jaFavoritado)
            {
                return Json(new { success = false, message = "Livro já está nos favoritos." });
            }

            // Adicionar aos favoritos
            var favorito = new Favorito
            {
                UsuarioId = usuario.Id,
                LivroId = livroId,
                DataFavoritado = DateTime.Now
            };

            _context.Favoritos.Add(favorito);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Livro adicionado aos favoritos!" });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao adicionar favorito para o usuário");
            return Json(new { success = false, message = "Erro ao adicionar aos favoritos." });
        }
    }

    // POST: Favoritos/RemoverFavorito/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoverFavorito(int livroId)
    {
        try
        {
            var usuario = await _userManager.GetUserAsync(User);
            if (usuario == null)
            {
                return Json(new { success = false, message = "Usuário não autenticado." });
            }

            var favorito = await _context.Favoritos
                .FirstOrDefaultAsync(f => f.UsuarioId == usuario.Id && f.LivroId == livroId);

            if (favorito == null)
            {
                return Json(new { success = false, message = "Livro não está nos favoritos." });
            }

            _context.Favoritos.Remove(favorito);
            await _context.SaveChangesAsync();

            return Json(new { success = true, message = "Livro removido dos favoritos." });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao remover favorito do usuário");
            return Json(new { success = false, message = "Erro ao remover dos favoritos." });
        }
    }

    // GET: Favoritos/VerificarFavorito/5
    public async Task<IActionResult> VerificarFavorito(int livroId)
    {
        try
        {
            var usuario = await _userManager.GetUserAsync(User);
            if (usuario == null)
            {
                return Json(new { isFavorito = false });
            }

            var isFavorito = await _context.Favoritos
                .AnyAsync(f => f.UsuarioId == usuario.Id && f.LivroId == livroId);

            return Json(new { isFavorito });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao verificar favorito");
            return Json(new { isFavorito = false });
        }
    }
}