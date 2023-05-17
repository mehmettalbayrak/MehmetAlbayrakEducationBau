using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BooksApp.MVC.Models;
using BooksApp.Business.Abstract;

namespace BooksApp.MVC.Controllers;

public class HomeController : Controller
{
    private readonly IBookService _bookManager;

    public HomeController(IBookService bookManager)
    {
        _bookManager = bookManager;
    }

    public async Task<IActionResult> Index()
    {
        var books = await _bookManager.GetHomePageBooksAsync();
        return View(books);
    }

}
