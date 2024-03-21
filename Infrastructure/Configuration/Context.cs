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
        public DbSet<Fornecedor> Fornecedor { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Produto>().ToTable("PRODUTO");
            builder.Entity<Fornecedor>().ToTable("FORNECEDOR");
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
            string strCon = "Server=localhost\\SQLEXPRESS;Database=CatalogoProdutos;Trusted_Connection=True;";
            return strCon;
        }
    }
}
