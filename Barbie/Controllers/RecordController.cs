using Barbie.Interfaces;
using Barbie.Models;
using Microsoft.AspNetCore.Mvc;

namespace Barbie.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordController : ControllerBase
    {
        private readonly IRecordService _recordService;

        public RecordController(IRecordService recordService)
        {
            _recordService = recordService;
        }

        [HttpGet]
        public async Task<IActionResult> GetRecords()
        {
            var records = await _recordService.GetAll();
            return Ok(records);
        }
    }
}
