using System;
namespace Catalog.Service.EventHandlers.Exceptions
{
    public class ProductInStockUpdateStockException : Exception
    {
        public ProductInStockUpdateStockException(string message) : base(message) {}

    }
}

