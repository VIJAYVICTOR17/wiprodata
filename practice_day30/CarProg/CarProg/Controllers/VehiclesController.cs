using CarProg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarProg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VehiclesController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize]
        // 2) Show All Vehicles
        // GET: api/Vehicles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            return await _context.Vehicles.ToListAsync();
        }

        // 1) Add Vehicle
        // POST: api/Vehicles
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetVehicles), new { id = vehicle.vehicleID }, vehicle);
        }

        // 3) Show Vehicles by Type (make)
        // GET: api/Vehicles/type/Toyota
        [HttpGet("type/{make}")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehiclesByMake(string make)
        {
            var vehicles = await _context.Vehicles
                .Where(v => v.make.ToLower() == make.ToLower())
                .ToListAsync();

            if (!vehicles.Any())
            {
                return NotFound($"No vehicles found for make: {make}");
            }

            return vehicles;
        }

        // 4) Show Vehicles by Type AND Availability
        // GET: api/Vehicles/type/Toyota/available
        [HttpGet("type/{make}/{status}")]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehiclesByMakeAndStatus(string make, string status)
        {
            if (string.IsNullOrEmpty(status) ||
                (status.ToLower() != "available" && status.ToLower() != "notavailable"))
            {
                return BadRequest("Status must be either 'available' or 'notAvailable'.");
            }

            var vehicles = await _context.Vehicles
                .Where(v => v.make.ToLower() == make.ToLower() && v.status.ToLower() == status.ToLower())
                .ToListAsync();

            if (!vehicles.Any())
            {
                return NotFound($"No vehicles found for make '{make}' with status '{status}'.");
            }

            return vehicles;
        }
    }
}
