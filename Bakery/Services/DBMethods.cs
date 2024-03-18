using Bakery.db;
using Bakery.Models;
using System.Reflection;


namespace Bakery.Services
{
    public class DBMethods
    {
        public static void Seed(MyDbContext db)
        {
            Ingredients Flour = new Ingredients()
            {
                Name = "Flour",
                Unit = "Kg",
                StockAmount = 20
            };

            // Ingredients
            db.Ingredients.Add(new Ingredients() { Name = "Plain Flour", Unit = "Kg", StockAmount = 20});
            db.Ingredients.Add(new Ingredients() { Name = "Butter", Unit = "Kg", StockAmount = 4});
            db.Ingredients.Add(new Ingredients() { Name = "Egg", Unit = "pcs", StockAmount = 100 });
            db.Ingredients.Add(new Ingredients() { Name = "Vanilla Extract", Unit = "Kg", StockAmount = 1});
            db.Ingredients.Add(new Ingredients() { Name = "White sugar", Unit = "Kg", StockAmount = 2 });
            db.Ingredients.Add(new Ingredients() { Name = "Milk", Unit = "L", StockAmount = 10 });
            db.Ingredients.Add(new Ingredients() { Name = "Salt", Unit = "g", StockAmount = 500 });

            db.SaveChanges();
           
        }
    }
}
