﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YourBook.Models
{
    public class Min18YearsIfAMember: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
                if (customer.MembershipTypeId == MembershipType.Free ||customer.MembershipTypeId == MembershipType.Notdefined) 
                    return ValidationResult.Success;

                if (customer.Birthdate == null)
                    return new ValidationResult("Birthdate is required");

            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Customer needs to be at least 18 years old for this membership type");
        }



    }
}