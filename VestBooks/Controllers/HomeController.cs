using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VestBooks.Data;
using VestBooks.Models;
using VestBooks.ViewModels;

namespace VestBooks.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _db;

    public HomeController(ILogger<HomeController> logger, AppDbContext db)
    {
        _logger = logger;
        _db = db;
    }

    public IActionResult Index()
    {
        HomeVM home = new()
        {
            Livros = _db.Livros
                .Where(p => p.Destaque)
                .ToList(),
            Faculdades = _db.Faculdades.ToList()
        };
        return View(home);
    }

    public IActionResult Vestibular(int id)
    {
        var vestibular = _db.Faculdades
            .Where(v => v.Id == id)
            .Include(v => v.Livros)
            .ThenInclude(vl => vl.Livro)
            .ThenInclude(l => l.Autor)
            .Include(v => v.Perguntas)
            .ThenInclude(p => p.PerguntaAlternativas)
            .SingleOrDefault();
        return View(vestibular);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Livro(int id)
    {
        var livro = _db.Livros
            .Where(l => l.LivroId == id)
            .Include(l => l.Autor)
            .Include(l => l.Faculdades)
            .ThenInclude(fl => fl.Faculdade)
            .SingleOrDefault();
        return View(livro);
    }   

    public IActionResult Perguntas(int id)
    {
        var vestibular = _db.Faculdades
            .Where(v => v.Id == id)
            .Include(v => v.Livros)
            .ThenInclude(vl => vl.Livro)
            .ThenInclude(l => l.Autor)
            .Include(v => v.Perguntas)
            .ThenInclude(p => p.PerguntaAlternativas)
            .SingleOrDefault();
        return View(vestibular);
    }

    public IActionResult Autor(int id)
    {
        var autor = _db.Autores
            .Where(a => a.AutorId == id)
            .Include(a => a.Livros)
            .FirstOrDefault();
        return View(autor);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}