using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Barbie.Data;
using Barbie.Models;

namespace Barbie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BarberController : ControllerBase
    {
        private readonly DataContext context;


        public BarberController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBarbers()
        {
            var barbers = await context.Barbers.ToListAsync();
            await context.SaveChangesAsync();
            return Ok(barbers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBarber(int id)
        {
            var barber = await context.Barbers.FindAsync(id);
            if(barber == null)
                return NotFound("Barber not found");
            
            return Ok(GetAllBarbers());
        }

        [HttpPost("AddBarber")]
        public async Task<IActionResult> AddAdmin(Barber barber)
        {
            context.Barbers.Add(barber);
            
            await context.SaveChangesAsync();
            return Ok(GetAllBarbers());
        }

  
    }
}
