using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Barbie.Data;
using Barbie.Mappers;
using Barbie.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Barbie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly DataContext context;

        public UserController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var user = await context.Users.ToListAsync();
            return Ok();
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
                return NotFound("User not found");
            await context.SaveChangesAsync();
            return Ok(GetAllUsers());

        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null)
                return NotFound("User not found");

            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return Ok("User add successfully");

        }    
        
        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return Ok("User delete successfully");

        }
        
    }
}

