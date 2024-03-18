using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    public class BakingGood_Packet
    {
        //[Key]
        //public int BakingGood_Packet_Id { get; set; }

        [ForeignKey("GoodsId")]
        public int GoodsId { get; set; }
        //public BakingGood Bakinggood { get; set; }

        [ForeignKey("PacketId")]
        public int PacketId { get; set; }
        //public Packet Packet { get; set; }
        public int Amount { get; set; }
    }
}