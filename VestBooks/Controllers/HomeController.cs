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
            .SingleOrDefault();
        return View(vestibular);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Enem()
    {
        return View();
    }

    public IActionResult Livros()
    {
        return View();
    }

    public IActionResult Perguntas()
    {
        return View();
    }

    public IActionResult Usp()
    {
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}