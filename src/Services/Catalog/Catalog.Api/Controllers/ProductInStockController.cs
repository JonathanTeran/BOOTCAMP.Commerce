using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Service.EventHandlers;
using Catalog.Service.EventHandlers.Commands;
using Catalog.Service.Queries.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Catalog.Api.Controllers
{
    [Route("v1/stocks")]
    public class ProductInStockController : ControllerBase
    {

        private readonly ILogger<ProductInStockController> _logger;
        private readonly IMediator _mediator;

        public ProductInStockController(ILogger<ProductInStockController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }


        //falta


        // GET: api/values
        [HttpPut]
        public async Task<IActionResult> UpdateStock(ProductInStockUpdateStockEventHandler command)
        {
            await _mediator.Publish(command);
            return NoContent();
        }
 
    }
}

