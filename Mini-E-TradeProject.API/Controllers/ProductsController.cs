using Microsoft.AspNetCore.Mvc;
using Mini_E_TradeProject.Application.Abstraction;
using Mini_E_TradeProject.Application.Repositories;

namespace Mini_E_TradeProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private readonly IProductService _productService;

        //public ProductsController(IProductService productService)
        //{
        //    _productService = productService;
        //}

        //[HttpGet]
        //public IActionResult GetProducts()
        //{
        //    var products = _productService.GetProducts();

        //    return Ok(products);
        //}

        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async void Get()
        {
           await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "TestName", CreatedDate = DateTime.UtcNow, Price  = 100, Stock = 10 },
                new() { Id = Guid.NewGuid(), Name = "TestName2", CreatedDate = DateTime.UtcNow, Price = 100, Stock = 10 },
            });

           var aa = await _productWriteRepository.SaveAsync();
        }
    }
}