using System;
using Catalog.Persistence;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Catalog.Persistence.Database.Configuration
{
	public class ProductInStockConfiguration
	{
		public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityTypeBuilder)
		{
			entityTypeBuilder.HasKey(x => x.ProductInStockId);
            var ramdon = new Random();
            var stocks = new List<ProductInStock>();

            for (int i = 1; i <= 100; i++)
            {
                stocks.Add(new ProductInStock
                {
                    ProductInStockId = i,
                    ProductId = i,
                    Stock = ramdon.Next(0,40)
                    
                });


            }
            entityTypeBuilder.HasData(stocks);

        }
    }
}

