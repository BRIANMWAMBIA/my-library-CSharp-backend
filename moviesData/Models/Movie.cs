using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace moviesData
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title  { get; set; }
        [Required]
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        public string type{ get; set; }

    [Required]
        public string Main_Actor { get; set; }
        
    }
}
