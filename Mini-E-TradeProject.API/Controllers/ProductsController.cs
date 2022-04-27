using Microsoft.AspNetCore.Mvc;

namespace Mini_E_TradeProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {

            return Ok();
        }
    }
}