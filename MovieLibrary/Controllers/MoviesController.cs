using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using movieLibrary.Models;
using movieLibrary.Models.Movies;
using moviesData;
using System;
using System.Linq;

namespace movieLibrary.Controllers
{
    public class MoviesController : Controller
    {
        private  IMovies _movies;
        public MoviesController(IMovies movies)
        {
            _movies= movies;
        }
        // GET: MoviesController
       
        
        public ActionResult index()
        {
            var movies = _movies.GetAll();
            var moviesList = movies.Select(result => new MoviesViewModel
            {
                id = result.Id,
                Title = result.Title,
                Category=result.Category
            });
            var model = new MoviesListingModel()
            {
                movies = moviesList
            };

            return View(model);
        }

        // GET: MoviesController/Details/5
        public ActionResult Details(int id)
        {
           var movie = _movies.GetById(id);
            var model = new DetailsViewModel 
            {
                Id= movie.Id,
                Title = movie.Title,
                Description = movie.Description,
                Category = movie.Category,
                Type = movie.type
            };
            
            return View(model);
        }

        // GET: MoviesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MoviesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Movie movie)
        {
            if (movie != null)
            {
                _movies.add(movie);
                return RedirectToAction("Create");

            }
            else 
                return RedirectToAction("Index");


        }

        // GET: MoviesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MoviesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MoviesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MoviesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
