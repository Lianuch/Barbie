using Microsoft.AspNetCore.Mvc;
using Barbie.Dtos;
using Barbie.Interfaces;

namespace Barbie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BarberController : ControllerBase
    {
        private readonly IBarberService _barberService;

        public BarberController(IBarberService barberService)
        {
            _barberService = barberService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBarbers()
        {
            var barbers = await _barberService.GetAll();
            
            return Ok(barbers);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetBarber([FromRoute]Guid id)
        {
            var barber = await _barberService.Get(id);
            
            return Ok(barber);
        }

        [HttpPost]
        public async Task<IActionResult> AddBarber([FromBody] BarberCreateDto barber)
        {
            await _barberService.Create(barber);
            
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(Guid barber)
        {
            var barbers = await _barberService.Delete(barber);
            return Ok(barbers);
        }
    }
}