using Bakery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientController : ControllerBase
    {
        private readonly ILogger<IngredientController> _logger;

        public IngredientController(ILogger<IngredientController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetIngredients")]
        public IEnumerable<Ingredients> Get()
        {

        }
    }
}
