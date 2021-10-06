using Microsoft.AspNetCore.Mvc;
using moviesData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace movieLibrary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesAPIController : ControllerBase

    {
        private IMovies _movieservices;

        public MoviesAPIController (IMovies movieService )
        {
            _movieservices = movieService;
        }
        // GET: api/<MoviesAPIController>
        [HttpGet]
        public IEnumerable<Movie> Get()
         
        {
            var movie = _movieservices.GetAll();
            return movie;
        }

        // GET api/<MoviesAPIController>/5
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            var movie = _movieservices.GetById(id);
            return movie;
        }

        // POST api/<MoviesAPIController>
        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            _movieservices.add(movie);
            return Ok();
        }

        // PUT api/<MoviesAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Movie movie)
        {
           
            _movieservices.update(id,movie);
        }

        // DELETE api/<MoviesAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
          
            _movieservices.delete(id);
        }
    }
}
