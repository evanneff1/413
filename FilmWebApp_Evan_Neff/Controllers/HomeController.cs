//Ths is the Home Contrller page, the brains of the website. This handles any requests coming to the website and directs them to the appropiate locaitons.

using FilmWebApp_Evan_Neff.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FilmWebApp_Evan_Neff.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext _context;
        public HomeController(MovieContext temp)
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Joel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieDB()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieDB(Movies response) 
        {
            _context.movies.Add(response);
            _context.SaveChanges();
            
            return View("Submission", response);
        }

    }
}
