using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace movieLibrary.Models.Movies
{
    public class DetailsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
    }
}
