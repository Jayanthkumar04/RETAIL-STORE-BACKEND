using RETAIL_STORE_BACKEND.Data;
using RETAIL_STORE_BACKEND.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using RETAIL_STORE_BACKEND.DTO;
using RETAIL_STORE_BACKEND.Interfaces;

namespace RETAIL_STORE_BACKEND.Controllers
{
    [Route("product")]
    [ApiController]
    public class ProductController(AppDbContext _context,IMapper _mapper,IProductRepository _repo):ControllerBase
    {
        [HttpPost("AddProduct")]
        [ProducesResponseType(400)]
        [ProducesResponseType(204)]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            if(product == null)
            {
                return BadRequest(ModelState);
            }
           var result = await _context.Products.AddAsync(product);



            if (!ModelState.IsValid){
                return BadRequest(ModelState);
            }

            await _context.SaveChangesAsync();
            var products = _mapper.Map<ProductDto>(product);

            return Ok(products);
        }

        [HttpGet("getAll")]
        public async Task<IActionResult> GetAllProducts()
        {

            var result =await _repo.GetAllProducts();

            var products = _mapper.Map<List<ProductDto>>(result);

            return Ok(products);

        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            var result = await _repo.GetProductById(id);

            var product = _mapper.Map<ProductDto>(result);

            return Ok(product);
        }

        [HttpGet("brand/{brand}")]
        public async Task<IActionResult> GetProductsByBrand([FromRoute] string brand)
        {
            var result = await _repo.GetProductsByBrand(brand);


            var product = _mapper.Map<List<ProductDto>>(result);

            return Ok(product);
        }

        [HttpGet("category/{category}")]
        public async Task<IActionResult> GetProductsByCategory([FromRoute] string category)
        {
            var result = await _repo.GetProductsByCategory(category);

            var product = _mapper.Map<List<ProductDto>>(result);


            return Ok(product);
        }

        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] int id)
        {
            var result = await _repo.
        }


    }
}
