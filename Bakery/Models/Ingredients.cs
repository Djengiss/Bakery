using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class Ingredients
    {
        [Key]
        public int IngredientId { get; set; }
        public int StockAmount { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public List<BakingGoodIngredient> BakingGoodIngredients { get; set; }
        public List<BakingGood> BakingGoods { get; set; }
    }
}