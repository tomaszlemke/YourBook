﻿using System;
using System.ComponentModel.DataAnnotations;

namespace YourBook.Dtos
{
    public class BookDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Author { get; set; }
     
        public byte GenreId { get; set; }

        public DateTime DateAdded { get; set; }


        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }
    }
}