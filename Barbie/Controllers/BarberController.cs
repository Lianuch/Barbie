
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Barbie.Data;
using Barbie.Dtos;
using Barbie.Mappers;
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
        /*public async Task<IActionResult> GetAllBarbers()
        {
            var barbers = await context.Barbers.ToListAsync();
            return Ok(barbers);
        }  */
        //testing
        public async Task<IActionResult> GetAllBarbers()
        {
            var barbers = await context.Barbers
                .Select(b => new BarberDto()
                {
                    BarberClass = b.BarberClass,
                    BarberIncome = b.BarberIncome,
                    Records = b.Records,
                    Reviews = b.Reviews,
                    UserId = b.UserId
                })
                .ToListAsync();

            return Ok(barbers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBarber([FromBody]int id)
        {
            var barber = await context.Barbers.FindAsync(id);
            if(barber == null)
                return NotFound("Barber not found");
            await context.SaveChangesAsync();

            return Ok(GetAllBarbers());
        }

        [HttpPost]
        public async Task<IActionResult> AddBarber(Barber barber)
        {
            context.Barbers.Add(barber);
            
            await context.SaveChangesAsync();
            return Ok(GetAllBarbers());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBarber(int id)
        {
            var barber = await context.Barbers.FindAsync(id);
            if (barber == null)
                return NotFound("Barber not found");

            context.Barbers.Remove(barber);
            await context.SaveChangesAsync();
            return Ok(GetAllBarbers());
        }


  
    }
}
