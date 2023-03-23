﻿using System;
using Catalog.Persistence;
using Catalog.Persistence.Database;
using Catalog.Service.EventHandlers.Commands;
using MediatR;

namespace Catalog.Service.EventHandlers
{
    public class ProductCreateEventhandler : INotificationHandler<ProductCreateCommand>
    {
        private readonly CatalogDbContext _context;
        public ProductCreateEventhandler(CatalogDbContext context) { _context = context; }

        public async Task Handle(ProductCreateCommand command, CancellationToken cancellationToken)
        {
            await _context.AddAsync(new Product
            {
                Name = command.Name,
                Description= command.Description,
                Price= command.Price

            });
            await _context.SaveChangesAsync();
            
        }
    }
}

