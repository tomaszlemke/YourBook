using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace YourBook.Models
{
    public class Genre
    {
        public byte Id { get; set; }

        [Required(ErrorMessage = "Please select Genre")]
        [StringLength(255)]
        public string Name { get; set; }
    }
}