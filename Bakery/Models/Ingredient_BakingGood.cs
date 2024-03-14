using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Ingredient_BakingGood
    {
        [Key]
        public int Ingredient_BakingGoo_Id { get; set; }
        public BakingGood Bakinggood { get; set; }
        public Ingredients ingredient{ get; set; }
        public int Amount { get; set; }
    }

}

