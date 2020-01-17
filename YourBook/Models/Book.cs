using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YourBook.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter book's name")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Author's name")]
        [StringLength(255)]
        public string Author { get; set; }

        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }


        [Display(Name = "Date Added")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Please enter release date")]
        [Display(Name = "Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "Please enter number in stock 1-20")]
        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}