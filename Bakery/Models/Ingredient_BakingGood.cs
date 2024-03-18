using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Ingredient_BakingGood
    {
        [Key]
        public int Ingredient_BakingGoo_Id { get; set; }
        public int GoodsId { get; set; }
        public int IngredientId { get; set; }
        public int Amount { get; set; }
    }

}

