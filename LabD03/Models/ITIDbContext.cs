using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LabD03.Models
{   
    internal class ITIDbContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=.;Database=Blog;Trusted_Connection=True ;TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
