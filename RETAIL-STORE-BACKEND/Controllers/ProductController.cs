using RETAIL_STORE_BACKEND.Data;
using RETAIL_STORE_BACKEND.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using RETAIL_STORE_BACKEND.DTO;

namespace RETAIL_STORE_BACKEND.Controllers
{
    [Route("product/[controller]")]
    [ApiController]
    public class ProductController(AppDbContext _context,IMapper _mapper):ControllerBase
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
    }
}
