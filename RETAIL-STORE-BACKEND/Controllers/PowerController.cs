using AutoMapper;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RETAIL_STORE_BACKEND.DTO;
using RETAIL_STORE_BACKEND.Interfaces;
using RETAIL_STORE_BACKEND.Models;
namespace RETAIL_STORE_BACKEND.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("power")]
    [ApiController]
    public class PowerController(IPowerRepository _repo, IMapper _mapper) :ControllerBase
    {
        [HttpPost("AddPower")]

        public async Task<IActionResult> AddPower([FromBody] Power power)
        {
            var result = await _repo.AddPower(power);

            var Power = _mapper.Map<PowerDto>(result);

            return Ok(Power);

        }
        [HttpGet("all")]
        public async Task<IActionResult> GetAllPowers()
        {
            var result = await _repo.GetAllPowers();

            var power = _mapper.Map<List<PowerDto>>(result);

            return Ok(power);
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetPowerByID([FromRoute] int id)
        {
            var result = await _repo.GetPowerById(id);
            var power = _mapper.Map<PowerDto>(result);

            return Ok(power);

        }

        [HttpGet("rating/{rating}")]
        public async Task<IActionResult> GetPowerByRating([FromRoute] string rating)
        {
            var result = await _repo.GetPowerByRating(rating);
            var power = _mapper.Map<PowerDto>(result);

            return Ok(power);

        }
    }
}
