using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMvc.Models.Department> Department { get; set; } = default!;
        public DbSet<SalesWebMvc.Models.Seller> Seller { get; set; } = default!;
        public DbSet<SalesWebMvc.Models.SalesRecord> SalesRecord { get; set; } = default!;

    }
}
