using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediaPlay.Services;
using Microsoft.AspNetCore.Mvc;
using MediaPlay.Models;


namespace MediaPlay.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        [Route("Ratings")]
        [HttpGet]
        public ActionResult Get([FromQuery] string ProductId, [FromQuery] int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }


        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
