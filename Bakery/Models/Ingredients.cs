using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class Ingredients
    {
        public int IngredientId { get; set; }
        public int StockAmount { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
    }
}