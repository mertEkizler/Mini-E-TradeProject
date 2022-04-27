﻿using Microsoft.AspNetCore.Mvc;
using Mini_E_TradeProject.Application.Abstraction;

namespace Mini_E_TradeProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();

            return Ok(products);
        }
    }
}