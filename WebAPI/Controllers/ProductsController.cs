using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController] // ATTRIBUTE
	public class ProductsController : ControllerBase
	{
		// Loosely coupled
		// Naming convention _
		// IoC Container -- Inversion of Control
		IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")] //-----------**
		public IActionResult GetAll()
		{
			// Dependency chain

			var result = _productService.GetAll();
			if (result.IsSuccess)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}

		[HttpGet("getbyid")] //------------**
		public IActionResult GetById(int id)
		{
			var result = _productService.GetById(id);
			if (result.IsSuccess) { return Ok(result.Data); }
			return BadRequest(result);
		}

		[HttpPost("add")] //----------** Ekleme, silme, güncelleştirme --> postta kullanılır genelde
		public IActionResult Add(Product product)
		{
			var result = _productService.Add(product);
			if (result.IsSuccess)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
