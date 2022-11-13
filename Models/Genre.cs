using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Genre
    {
        public int GenreId {get; set;}

        [Display(Name ="Genre")]
        public string GenreName {get; set;}

        public List<Movie> Movies {get; set;}
    }
}