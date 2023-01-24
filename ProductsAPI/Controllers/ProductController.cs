using Microsoft.AspNetCore.Mvc;
using Products.Application.Dtos;
using Products.Application.Interfaces;
using Products.Application.Responses;

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpGet]
        public ActionResult<ProductResponseDto> Get([FromQuery] PageDto pageDto)
        {
            var productResponseDto = _productAppService.Get(pageDto);
            return Ok(productResponseDto);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var product = _productAppService.GetById(id);

            if (product is null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDto)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var newProductDto =_productAppService.Add(productDto);

            return Ok(newProductDto);
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] ProductDto productDto)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            var updatedProductDto = _productAppService.Update(productDto);

            if (updatedProductDto is null)
            {
                return NotFound();
            }

            return Ok(updatedProductDto);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            if (!this.ModelState.IsValid)
            {
                return BadRequest(this.ModelState);
            }

            _productAppService.Delete(id);

            return Ok();
        }
    }
}
