using Barbie.Data;
using Barbie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barbie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly DataContext context;
        public ReviewController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAllReview")]
        public async Task<IActionResult> GetAllReviews()
        {
            var review = context.Reviews.ToListAsync();
            await context.SaveChangesAsync();
            return Ok(review);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReview(int id)
        {
            var review = await context.Reviews.FindAsync(id);
            if (review == null)
                return NotFound("Review not found");
            await context.SaveChangesAsync();
            return Ok(GetAllReviews());
        }
        [HttpPost]
        public async Task<IActionResult> AddReview(Review review)
        {
            context.Reviews.Add(review);
            await context.SaveChangesAsync();
            return Ok(GetAllReviews());
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await context.Reviews.FindAsync(id);
            if (review == null)
                return NotFound("Review not found");

            context.Reviews.Remove(review);
            await context.SaveChangesAsync();
            return Ok(GetAllReviews());
        }


        [HttpPut]
        public async Task<IActionResult> UpdateReview(Review review)
        {
            var dbReview =  await context.Reviews.FindAsync(review.Id);
            if (dbReview == null)
                return NotFound("Review not found");

            dbReview.Text = review.Text; 
            dbReview.Value = review.Value; 
            
            await context.SaveChangesAsync();
            return Ok(GetAllReviews());
        }
    }
}
