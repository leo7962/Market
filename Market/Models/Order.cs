using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Branch IdBranch { get; set; }

       

        [Required]
        public Customer IdCustomer { get; set; }

        [Required]
        public DetailProduct IdDetailProduct { get; set; }

        [Required]
        public IEnumerable<Product> Products { get; set; }

    }
}
