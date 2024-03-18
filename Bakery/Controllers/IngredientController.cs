using Bakery.db;
using Bakery.Models;
using Bakery.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections;

namespace Bakery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly ILogger<IngredientController> _logger;
        private readonly MyDbContext _db;

        public IngredientController(ILogger<IngredientController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetIngredients")]
        public IEnumerable<Ingredients> Get()
        {
            return _db.Ingredients.ToList();
        }
    }
}
