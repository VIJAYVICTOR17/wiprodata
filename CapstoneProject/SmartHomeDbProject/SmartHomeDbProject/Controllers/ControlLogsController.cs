using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartHomeDbProject.Models;

namespace SmartHomeDbProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControlLogsController : ControllerBase
    {
        private readonly SmartHomeDbContext _context;

        public ControlLogsController(SmartHomeDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/Sensors (all sensors)
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ControlLog>>> GetControlLog()
        {
            return await _context.ControlLog.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<ControlLog>> PostControlLog(ControlLog controlLog)
        {
            controlLog.ActionTime = DateTime.Now;

            // Use ExecuteSqlRaw instead of EF insert (avoids OUTPUT)
            await _context.Database.ExecuteSqlRawAsync(
                "INSERT INTO ControlLog (SensorId, Action, ActionTime) VALUES ({0}, {1}, {2})",
                controlLog.SensorId, controlLog.Action, controlLog.ActionTime
            );

            // Optionally fetch last inserted record
            var savedLog = await _context.ControlLog
                .OrderByDescending(c => c.LogId)
                .FirstOrDefaultAsync();

            return CreatedAtAction(nameof(GetControlLog), new { id = savedLog.LogId }, savedLog);
        }

        private bool ControlLogExists(int id)
        {
            return _context.ControlLog.Any(e => e.LogId == id);
        }
    }
}
