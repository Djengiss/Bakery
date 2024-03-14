using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class BakingGood
    {
        [Key]
        public int GoodsId { get; set; }
        public string Recipe { get; set; }
        public int DaysOfValidity { get; set; }
        public string Name { get; set; }

        public Packet? Packet { get; set; }
        public Dictionary<Ingredients, int> Ingredients { get; set; }
        public List<BakeryBatch> Batches { get; set; }
    }
}