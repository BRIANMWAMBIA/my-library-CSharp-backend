using Microsoft.EntityFrameworkCore;
using moviesData;
using System;
using System.Collections.Generic;
using System.Linq;

namespace moviesServices
{
    public class MovieService : IMovies
    {
        private LibraryContext _context;
        public MovieService(LibraryContext context)
        {
            _context = context;
        }
        public void add(Movie movie)  //creating a new video in the databse
        {  
            if(movie != null)
            {
                _context.Add(movie);
                _context.SaveChanges();
            }
            
        }

        public IEnumerable<Movie> GetAll() //Retrieving all the videos from the database
        {
            return _context.Movies;
        }

        public Movie GetById(int id)  //retrieving a single movie by its id
        {
            return _context.Movies
                  .FirstOrDefault(asset => asset.Id == id);
            //return GetAll()
            //.FirstOrDefault(asset=>asset.Id==id)
        }

        public Movie GetByTitle(String title)  //retrieving a single movie by its title
        {
            return _context.Movies
                .FirstOrDefault(asset => asset.Title == title);
            //return GetAll()
            //.FirstOrDefault(asset=>asset.Title == title)
        }

        public string GetCategory(int id)  //return the category of given movie
        {
            return _context.Movies
                 .FirstOrDefault(asset => asset.Id == id).Category;
            //return GetAll()
            //.FirstOrDefault(asset=>asset.Id ==id).Category;

        }

        public string GetCategoryByTitle(string title)  //return the category of given movie
        {
            return _context.Movies
                 .FirstOrDefault(asset => asset.Title == title).Category;
            //return GetAll()
            //.FirstOrDefault(asset=>asset.Id ==id).Category;

        }

        public string GetTitle(int id)   //return the title given an id
        {
            return _context.Movies
                .FirstOrDefault(asset => asset.Id == id).Title;
            //return GetAll()
            //.FirstOrDefault(asset=>asset.Id==id).Title;
        } 
      

        public void delete(int id)
        {
          var  movie = GetById(id);
            _context.Remove(movie);
            _context.SaveChanges();
        }

        public void update(int id,Movie movie)
        {
            Movie movi = GetById(id);
            movi.Id = id;
            movi.Main_Actor = movie.Main_Actor;
            movi.Title = movie.Title;
            movi.type = movie.type;
            movi.Category = movie.Category;
            movi.Description = movie.Description;


            _context.Update(movi);
            _context.SaveChanges();
        }
    }
}
