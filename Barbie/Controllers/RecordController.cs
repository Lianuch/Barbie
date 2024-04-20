using Barbie.Data;
using Barbie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Barbie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly DataContext context;
        public RecordController(DataContext context)
        {
            this.context = context;
        }

        [HttpGet("GetAllRecords")]
        public async Task<IActionResult> GetAllRecords()
        {
            var record = await context.Records.ToListAsync();
            await context.SaveChangesAsync();

            return Ok(record);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRecord(int id)
        {
            var record = await context.Records.FindAsync(id);
            if(record == null) 
                return NotFound("Record not found");
            
            await context.SaveChangesAsync();
            return Ok(GetAllRecords());
        }

        [HttpPost]
        public async Task<IActionResult> AddRecord(Record record)
        {
            context.Records.Add(record);
            await context.SaveChangesAsync();
            return Ok(GetAllRecords());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRecord(int id)
        {
            var record = await context.Records.FindAsync(id);
            if (record == null)
                return NotFound("Record not found");
            context.Records.Remove(record);
            await context.SaveChangesAsync();
            return Ok(GetAllRecords());
        }


        [HttpPut]
        public async Task<IActionResult> UpdateRecord(Record record)
        {
            var dbRecord = await context.Records.FindAsync(record.Id);
            if (dbRecord == null)
                return NotFound("Record not found");
            dbRecord.Price = record.Price;
            dbRecord.RecordDate = record.RecordDate;            


            await context.SaveChangesAsync();
            return Ok(GetAllRecords());
        
        }

    }
}
