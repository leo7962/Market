using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Telephone { get; set; }

        [Required]
        public IEnumerable<Customer> Customers { get; set; }

        [Required]
        public IEnumerable<Order> Orders { get; set; }

    }
}
