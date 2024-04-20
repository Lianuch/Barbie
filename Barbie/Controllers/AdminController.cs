using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Barbie.Data;
using Barbie.Models;

namespace Barbie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AdminController : ControllerBase
    {
        private readonly DataContext context;

        public AdminController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdmin(int id)
        {
            var admin = await context.Admins.FindAsync(id);
            if(admin == null)
                return NotFound("Admin not found");

            await context.SaveChangesAsync();
            return Ok(admin);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAdmins()
        {
            var admins = await context.Admins.ToListAsync();
            
            await context.SaveChangesAsync();
            return Ok(admins);
        }
        
        [HttpPost("AddAdmin")]
        public async Task<IActionResult> AddAdmin(Admin admin)
        {
            context.Admins.Add(admin);
            
            await context.SaveChangesAsync();
            return Ok(GetAllAdmins());
        }
        
    
        
    }
}