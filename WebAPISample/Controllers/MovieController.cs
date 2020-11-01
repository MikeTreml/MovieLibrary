using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using WebAPISample.Data;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private ApplicationContext _context;
        public MovieController(ApplicationContext context)
        {
            _context = context;
        }
        // GET api/movie
        [HttpGet]
        public IActionResult Get()
        {
            var movieList = _context.Movies.ToList();// ithink this is the correct way to do this.
            //var movieList = _context.Movies.Where(m =>m.MovieId == m.MovieId).ToList();
		    return Ok(movieList);
		}

        // GET api/movie/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // Retrieve movie by id from db logic
            // return Ok(movie);
            var movie = _context.Movies.Where(m => m.MovieId == id);
            return Ok(movie);
        }
        [HttpGet, Route("search/{search}")]
        public IActionResult Get(string search)
        {
            var movies = from m in _context.Movies
                         select m;
            if (!String.IsNullOrEmpty(search))
            {
                movies = movies.Where(m => m.Title.Contains(search)
                                                || m.Year.Contains(search)
                                                || m.Genre.Contains(search)
                                                || m.Director.Contains(search)
                                                || m.Actors.Contains(search));
            }
            return Ok(movies);
        }

        // POST api/movie
        [HttpPost]
        public IActionResult Post([FromBody]Movie value)
        {
            _context.Add(value);
            _context.SaveChanges();
            return Ok();
        }

        // PUT api/movie
        [HttpPut]
        public IActionResult Put([FromBody] Movie movie)
        {
            // Update movie in db logic
           
            _context.Movies.Update(movie);// Added by Mike Treml 10/29
            _context.SaveChanges();
            return Ok();
        }

        // DELETE api/movie/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Delete movie from db logic
            var movie = _context.Movies.Where(m => m.MovieId == id).FirstOrDefault();// Added by Mike Treml 10/29
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return Ok();
        }
    }
}