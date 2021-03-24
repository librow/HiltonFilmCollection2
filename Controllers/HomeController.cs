using HiltonFilmCollection2.Models;
using HiltonFilmCollection2.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //private IMovieRepository _repository;
        private MovieDbContext _context { get; set; }

        public HomeController(ILogger<HomeController> logger, MovieDbContext context)
        {
            _logger = logger;
            _context = context;
            //_repository = repository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MovieList()
        {
            return View(_context.Movies);
            //return View(
            //    new MovieListViewModel
            //    {
            //        Movies = _repository.Movies
            //        .OrderBy(m => m.movieId)
            //    });
        }

        [HttpGet]
        public IActionResult MovieSubmission()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSubmission(Movie movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            // Finds the movie matching the id to populate the edit form
            return View(_context.Movies.Where(m => m.movieId == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            // Modifies the record with the changes
            _context.Entry(movie).State = EntityState.Modified;
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            // Removes the record matching the id
            _context.Remove(_context.Movies.Where(m => m.movieId == id).FirstOrDefault());
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
