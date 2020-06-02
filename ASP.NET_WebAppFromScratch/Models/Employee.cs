﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace ASP.NET_WebAppFromScratch.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Name cannot exceed 50 characters.")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid Email Format.")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        [Required]
        public Dept? Department { get; set; }
    }
 }
