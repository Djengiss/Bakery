using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    public class Ingredient_BakingGood
    {
        [Key]
        public int Ingredient_BakingGood_Id { get; set; }

        [ForeignKey("Bakinggood")]
        public int GoodsId { get; set; }
        public BakingGood Bakinggood { get; set; }

        [ForeignKey("ingredient")]
        public int IngredientId { get; set; }
        public Ingredients ingredient { get; set; }
        public int Amount { get; set; }
    }

}

