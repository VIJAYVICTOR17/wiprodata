using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartHomeDbProject.Models;
using Microsoft.EntityFrameworkCore;

namespace SmartHomeDbProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorsDataController : ControllerBase
    {
        private readonly SmartHomeDbContext _context;

        public SensorsDataController(SmartHomeDbContext context)
        {
            _context = context;
        }

        // ✅ GET: api/Sensors (all sensors)
        [Authorize]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SensorsData>>> GetSensorsData()
        {
            return await _context.SensorsData.ToListAsync();
        }

        // ✅ POST: api/Sensors (add new sensor)
        [HttpPost]
        public async Task<ActionResult<SensorsData>> PostSensorData(SensorsData sensorData)
        {
            // Set timestamp explicitly
            sensorData.ReadingTime = DateTime.Now;

            // Insert manually to avoid OUTPUT clause
            await _context.Database.ExecuteSqlRawAsync(
                "INSERT INTO SensorsData (DeviceId, SensorType, SensorStatus, ReadingTime) VALUES ({0}, {1}, {2}, {3})",
                sensorData.DeviceId,
                sensorData.SensorType,
                sensorData.SensorStatus,
                sensorData.ReadingTime
            );

            return Ok(new { message = "Sensor data inserted successfully" });
        }


        private bool SensorExists(int id)
        {
            return _context.SensorsData.Any(e => e.SensorId == id);
        }
    }
}
