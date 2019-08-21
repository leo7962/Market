using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Market.Models
{
    public class DetailProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int MyProperty { get; set; }

        [Required]
        public Product Product { get; set; }
    }
}
