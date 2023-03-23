using System;
using Catalog.Persistence;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Database.Configuration
{
	public class ProductConfiguration
	{
		public ProductConfiguration(EntityTypeBuilder<Product> entityTypeBuilder) {

			entityTypeBuilder.HasKey(x => x.ProductId);

			entityTypeBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
			entityTypeBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);

			var ramdon = new Random();
			var products = new List<Product>();


			for (int i = 1; i <= 100; i++) {
				products.Add(new Product
				{
					ProductId = i,
					Name= $"Product {i}",
					Description= $"Description for product {i}",
					Price = ramdon.Next(100,1000)


				}) ;
				

			}
			entityTypeBuilder.HasData(products);


        }
		
	}
}

