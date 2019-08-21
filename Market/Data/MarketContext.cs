using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Market.Models;

namespace Market.Models
{
    public class MarketContext : DbContext
    {
        public MarketContext (DbContextOptions<MarketContext> options)
            : base(options)
        {
        }

        public DbSet<Market.Models.Customer> Customer { get; set; }

        public DbSet<Market.Models.Product> Product { get; set; }

        public DbSet<Market.Models.Employee> Employee { get; set; }

        public DbSet<Market.Models.Branch> Branch { get; set; }

        public DbSet<Market.Models.DetailProduct> DetailProduct { get; set; }

        public DbSet<Market.Models.Order> Order { get; set; }
    }
}
