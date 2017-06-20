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

        [HttpGet()]
        public IActionResult Get()
        {
            var stockStates = _priceWebContext.GetAllStockStates();

            if (stockStates == null)
                return NotFound();

            return Ok(stockStates);
        }

        [HttpPost]
        public IActionResult GetStockStates([FromBody] ValidationModels.Post.ItemsAndPharmacies model)
        {
            if (!ModelState.IsValid)
                return new BadRequestObjectResult(new { message = ModelState.Values });

            var stockStates = _priceWebContext.GetInventoryForItemsOnPharmacies(model);

            if (stockStates == null)
                return NotFound();

            return Ok(stockStates); 
        }

        [HttpGet("/items/{itemNo}/")]
        public IActionResult GetAllStockStatesForItem(int itemNo)
        {
            var stockStates = _priceWebContext.GetStockStatesForItem(itemNo);

            if (stockStates == null)
                return NotFound();

            return Ok(stockStates);
        }
    }
}
