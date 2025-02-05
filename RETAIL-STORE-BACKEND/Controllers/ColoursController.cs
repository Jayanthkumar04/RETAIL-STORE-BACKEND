using System.Drawing;
using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RETAIL_STORE_BACKEND.DTO;
using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;

namespace RETAIL_STORE_BACKEND.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("colours")]
    [ApiController]
    public class ColoursController(IColourRepository _repo,IMapper _mapper):ControllerBase
    {
        [HttpPost("AddColour")]

        public async Task<IActionResult> AddColour([FromBody] Colour colour)
        {
            var result = await _repo.AddColour(colour);

            var colours = _mapper.Map<ColourDto>(result);

            return Ok(colours);

        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllColours()
        {
            var result = await _repo.GetAllColours();

            var colours = _mapper.Map<List<ColourDto>>(result);

            return Ok(colours);
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetColourByID([FromRoute] int id)
        {
            var result = await _repo.GetColourById(id);

            var colours = _mapper.Map<ColourDto>(result);

            return Ok(colours);

        }

        [HttpGet("rating/{colourname}")]
        public async Task<IActionResult> GetColourByName([FromRoute] string colourname)
        {
            var result = await _repo.GetColourByName(colourname);

            var colours = _mapper.Map<ColourDto>(result);

            return Ok(colours);
        }

    }
}
