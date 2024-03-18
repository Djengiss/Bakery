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

        public List<BakingGood_Packet> BakingGoodPackets { get; set; }
        public List<Packet> Packets { get; set; }
        public List<Ingredient_BakingGood> Ingredeients { get; set; }
        public List<BakeryBatch> Batches { get; set; }
    }
}