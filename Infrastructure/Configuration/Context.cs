using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.configuration
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Produto>().HasKey(p => p.Codigo);
            builder.Entity<Produto>().Property(p => p.Codigo).ValueGeneratedOnAdd();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(getConnectionSatring());
                base.OnConfiguring(optionsBuilder);
            }
        }

        public string getConnectionSatring()
        {
            string strCon = "Server=localhost\\SQLEXPRESS;Database=CatalogoProdutos;TrustServerCertificate=True;";
            return strCon;
        }
    }
}
