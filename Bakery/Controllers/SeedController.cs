using Bakery.db;
using Bakery.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    
        [ApiController]
        [Route("[controller]")]
        public class SeedController : ControllerBase
        {
            private readonly MyDbContext _context;

            public SeedController(MyDbContext context)
            {
                _context = context;
            }

            [HttpPost("seed")]
            public IActionResult SeedDatabase()
            {
                DBMethods.Seed(_context);
                return Ok("Database seeded successfully.");
            }
        }
    
}
