using System.Collections.Generic;
using System.Data.Entity;

namespace Laboratorio203.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDb") { }

        public DbSet<Laptop> Laptops { get; set; }
    }
}