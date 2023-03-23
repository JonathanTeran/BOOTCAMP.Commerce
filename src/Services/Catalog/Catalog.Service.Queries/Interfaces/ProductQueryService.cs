using Catalog.Persistence.Database;
using Catalog.Service.Queries.DTOs;
using Catalog.Service.Queries.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service.Common.Collection;
using Service.Common.Mapping;
using Service.Common.Paging;

public class ProductQueryService : IProdutQueryService
{
    private readonly CatalogDbContext _dbContext;

    public ProductQueryService(CatalogDbContext dbContext) { _dbContext = dbContext; }

    public async Task<DataCollection<ProductDto>> GetPagedAsync(int page, int take, IEnumerable<int> products = null)
    {
        var collection = await _dbContext.Products
            .Include(i =>i.Stock)
            .Where(x => products == null || products.Contains(x.ProductId))
            .OrderBy(or => or.ProductId)
            .GetPagedAsync(page, take);

        return collection.MapTo<DataCollection<ProductDto>>();
    }

    public async Task<IEnumerable<ProductDto>> GetAllAsync()
    {
        var collection = await _dbContext.Products.ToListAsync();
        return collection.MapTo<IEnumerable<ProductDto>>();
    }

    public async Task<ProductDto> GetAsync(int id)
    {
        var product = await _dbContext.Products.Include(i => i.Stock).FirstOrDefaultAsync(x => x.ProductId == id);
        return product.MapTo<ProductDto>();
    }
}