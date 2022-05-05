using Microsoft.AspNetCore.Mvc;
using Mini_E_TradeProject.Application.Repositories;

namespace Mini_E_TradeProject.API.Controllers
{

    // TEST CONTROLLER


    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //    new() { Id = Guid.NewGuid(), Name = "TestName3", CreatedDate = DateTime.UtcNow, Price = 105, Stock = 11 },
            //    new() { Id = Guid.NewGuid(), Name = "TestName4", CreatedDate = DateTime.UtcNow, Price = 104, Stock = 13 },
            //});

            //var aa = await _productWriteRepository.SaveAsync();

            var p = await _productReadRepository.GetByIdAsync("553383EE-3C25-41ED-8B40-05D7FD1AD641", false);
            p.Name = "mehmet";
            await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var response = await _productReadRepository.GetByIdAsync(id);

            return Ok(response);
        }
    }
}