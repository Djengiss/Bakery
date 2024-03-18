using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    public class BakingGood_Packet
    {
        [Key]
        public int BakingGood_Packet_Id { get; set; }
        public int GoodsId{ get; set; }
        public int PacketId { get; set; }
        public int Amount { get; set; }
    }
}