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

        private readonly ICustomerWriteRepository _customerWriteRepository;

        private readonly IOrderReadRepository _orderReadRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            IOrderWriteRepository orderWriteRepository,
            IOrderReadRepository orderReadRepository,
            ICustomerWriteRepository customerWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderReadRepository = orderReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
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

            //var p = await _productReadRepository.GetByIdAsync("553383EE-3C25-41ED-8B40-05D7FD1AD641", false);
            //p.Name = "mehmet";
            //await _productWriteRepository.SaveAsync();

            //await _productWriteRepository.AddAsync(new() { Name = "product1", CreatedDate = DateTime.UtcNow, Price = 1.500F, Stock = 23 });
            //await _productWriteRepository.SaveAsync();

            //var customerId = Guid.NewGuid();

            //var a = await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "customer1", Email = "aaa", PhoneNumber = "2342342" });

            //var b = await _orderWriteRepository.AddAsync(new() { Description = "blabla", Address = "ankere/cankaya", CustomerId = customerId });
            //var c = await _orderWriteRepository.AddAsync(new() { Description = "blabla222", Address = "ankere/kursaklar", CustomerId = customerId });

            //var d = await _orderWriteRepository.SaveAsync();

            var order = await _orderReadRepository.GetByIdAsync("AF4425D3-B975-4DFD-59A4-08DA2F6325C0");
            order.Address = "istanbul";

            await _orderWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var response = await _productReadRepository.GetByIdAsync(id);

            return Ok(response);
        }
    }
}