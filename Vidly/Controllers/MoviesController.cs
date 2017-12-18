using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() {
                Name = "Shrek!"
            };

            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //ViewData["Movie"] = movie;
            //ViewBag.Movie = movie;
            
            return View(viewModel);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ViewResult Index()
        {
            var movies = _context.Movies
                    .Include(m => m.Genre)
                    .ToList();

            return View(movies);
        }

        //movies/details
        public ActionResult Details(int id)
        {
            var movie = _context.Movies
                    .Include(m => m.Genre)
                    .SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}