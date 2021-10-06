using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieLibrary.Models.Movies
{
    public class MoviesListingModel
    {
        public IEnumerable<MoviesViewModel> movies { get; set; } 
    }
}
