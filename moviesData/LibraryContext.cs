using Microsoft.EntityFrameworkCore;
using moviesData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }
        

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}
