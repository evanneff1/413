//Ths is the Home Contrller page, the brains of the website. This handles any requests coming to the website and directs them to the appropiate locaitons.

using FilmWebApp_Evan_Neff.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            ViewBag.Category = _context.Categories
                .OrderBy(x => x.CategoryId) .ToList();

            return View("MovieDB", new Movies());
        }

        [HttpPost]
        public IActionResult MovieDB(Movies response) 
        {
            if (ModelState.IsValid) { 
            _context.Movies.Add(response);
            _context.SaveChanges();
            
            return View("Submission", response);
            }
            else
            {

                ViewBag.Category = _context.Categories
                    .OrderBy(x => x.CategoryId).ToList();
                return View(response);
            }
        }

        public IActionResult MovieList ()
        {
            //Linq
            var movies = _context.Movies
                .OrderBy(x => x.Title).ToList();
            ViewBag.Category = _context.Categories
                    .OrderBy(x => x.CategoryId).ToList();
            return View(movies);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieID == id);
            
            ViewBag.Category = _context.Categories
              .OrderBy(x => x.CategoryId).ToList();

            return View("MovieDB", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Movies updatedChanges)
        {
            _context.Update(updatedChanges);
            _context.SaveChanges();
            
            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieID == id);
            return View("Delete", recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movies updatedChanges)
        {
            _context.Movies.Remove(updatedChanges);
            _context.SaveChanges();


            return RedirectToAction("MovieList");
        }
    }
}
