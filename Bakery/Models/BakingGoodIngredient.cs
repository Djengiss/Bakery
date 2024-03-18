using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    public class BakingGoodIngredient
    {
        [ForeignKey("GoodId")]
        public int GoodId { get; set; }
        public BakingGood BakingGood { get; set; }

        [ForeignKey("IngredientId")]
        public int IngredientId { get; set; }
        public Ingredients Ingredient { get; set; }
        public int Amount { get; set; }
    }
}