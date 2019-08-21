﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Document { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public Branch Branch { get; set; }

        
    }
}
