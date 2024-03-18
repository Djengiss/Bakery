using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class BakingGood
    {
        [Key]
        public int GoodId { get; set; }
        public string Recipe { get; set; }
        public int DaysOfValidity { get; set; }
        public string Name { get; set; }
        public List<BakingGoodIngredient> BakingGoodIngredients { get; set; }
        //public List<Ingredients> Ingredients { get; set; }
        public List<BakingGoodPacket> BakingGoodPackets { get; set; }
        //public List<Packet> Packets { get; set; }
        public List<BakeryBatch> Batches { get; set; }
    }
}