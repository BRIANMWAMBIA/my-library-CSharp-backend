using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesData
{
    public interface IMovies
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);
        void add(Movie movie);
        Movie GetByTitle(string title);
        string GetTitle(int id);
        string GetCategory(int id);
        string GetCategoryByTitle(string title);
        void delete(int id);
        void update(int id,Movie movie);
    }
}
