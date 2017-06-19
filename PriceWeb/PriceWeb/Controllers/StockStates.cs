using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceWeb.Controllers
{
    [Route("api/[controller]")]
    public class StockStates : Controller
    {
        private Repositories.IPriceWeb _priceWebContext;

        public StockStates(Repositories.IPriceWeb priceWebContext)
        {
            _priceWebContext = priceWebContext; 
        }

        [HttpGet("{storeId}")]
        public IActionResult Get(string storeId)
        {

            return NotFound();
        }

        [HttpPost]
        public IActionResult GetStockStates([FromBody] ViewModels.Post.ItemsAndPharmacies model)
        {
            if (!ModelState.IsValid)
                return new BadRequestObjectResult(new { });

            var stockStates = _priceWebContext.GetInventoryForItemsOnPharmacies(model);

            if(stockStates == null)
                return NotFound();

            return Ok(stockStates); 
        }
    }
}
