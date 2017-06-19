using Microsoft.AspNetCore.Mvc;

namespace PriceWeb.Controllers
{
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        Repositories.IPriceWeb _priceWebContext;
        public ItemsController(Repositories.IPriceWeb priceWebContext)
        {
            _priceWebContext = priceWebContext;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Models.Item item = _priceWebContext.GetItem(id); 

            if (item == null)
                return NotFound();

            return Ok(item); 
        }
    }
}
