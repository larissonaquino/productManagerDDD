using Microsoft.EntityFrameworkCore;
using Products.Domain.Entities;
using Products.Domain.Interfaces;
using System;

namespace Products.Infrastructure.Data
{
    public class AppContext : DbContext, IAppDbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options)
        {
            this.Products = Set<Product>();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "Products");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder is null)
            {
                throw new ArgumentNullException(nameof(modelBuilder));
            }

            modelBuilder.Entity<Product>();

            base.OnModelCreating(modelBuilder);
        }

        void IAppDbContext.SaveProductChanges()
        {
            base.SaveChanges();
        }

        public DbSet<Product> Products { get; set; }
    }
}
