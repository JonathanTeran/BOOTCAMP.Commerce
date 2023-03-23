using System;
using Catalog.Persistence.Database;
using Catalog.Service.Queries.DTOs;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;

namespace Catalog.Service.Queries.Services
{
    public class ProductInStockQueryService
    {

        private readonly CatalogDbContext _dbContext;
        public ProductInStockQueryService(CatalogDbContext dbContext) { _dbContext = dbContext; }

        public async Task<DataCollection<ProductInStockDto>> GetPagedAsync(int page, int take, IEnumerable<int> productsInStock = null)
        {
            var collection = await _dbContext.ProductInStocks
                .Where(x => productsInStock == null || productsInStock.Contains(x.ProductId))
                //.OrderBy(or => or.Name)
                .GetPagedAsync(page, take);

             return collection.MapTo<DataCollection<ProductInStockDto>>();
           
        }



    }
}

