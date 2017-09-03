using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name="Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name="Date Added")]
        public DateTime? DateAdded { get; set; }

        [Required]
        [Range(1,20,ErrorMessage =  "Value must be between 1 and 20")]
        [Display(Name="Number in Stock")]
        public int NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name="Genre")]
        [Required]
        public int GenreId { get; set; }

        public int NumberAvailable { get; set; }

    }
}