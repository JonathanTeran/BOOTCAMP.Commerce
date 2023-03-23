using System;
using Catalog.Persistence;
using Catalog.Persistence.Database.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persistence.Database
{
	public class CatalogDbContext : DbContext
	{
		public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<ProductInStock> ProductInStocks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //database schems
            builder.HasDefaultSchema("Catalog");

            //model container
            ModelConfig(builder);
        }

        private void ModelConfig(ModelBuilder modelBuilder) {
			new ProductConfiguration(modelBuilder.Entity<Product>());
			new ProductInStockConfiguration(modelBuilder.Entity<ProductInStock>());
        }



    }
}

