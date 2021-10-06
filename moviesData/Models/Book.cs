using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moviesData.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
         public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public int Pages { get; set; }
        [Required]
            public string Type { get; set; }
        [Required]
        public string About { get; set; }
        
    }
}
