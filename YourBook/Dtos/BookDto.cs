using System;
using System.ComponentModel.DataAnnotations;

namespace YourBook.Dtos
{
    public class BookDto
     { 
     public int Id { get; set; }
    [Required(ErrorMessage = "Please enter book's name")]
    [StringLength(255)]
    public string Name { get; set; }

    [Required(ErrorMessage = "Please enter Author's name")]
    [StringLength(255)]
    public string Author { get; set; }

    public GenreDto Genre { get; set; }

    [Display(Name = "Genre")]
    [Required(ErrorMessage = "Please select Genre")]
    public byte GenreId { get; set; }

    public DateTime DateAdded { get; set; }

    [Display(Name = "Release Date")]
    public DateTime ReleaseDate { get; set; }

    [Display(Name = "Number in Stock")]
    [Range(1, 20)]
    public byte NumberInStock { get; set; }

    public byte NumberAvailable { get; set; }
}


}