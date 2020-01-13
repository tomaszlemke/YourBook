using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using YourBook.Models;

namespace YourBook.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Customer's name")]
        [StringLength(150)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeID { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

    }
}