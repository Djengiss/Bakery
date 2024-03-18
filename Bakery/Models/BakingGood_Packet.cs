using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class BakingGood_Packet
    {
        [Key]
        public int BakingGood_Packet_Id { get; set; }
        public BakingGood Bakinggood { get; set; }
        public Packet packet { get; set; }
        public int Amount { get; set; }
    }
}