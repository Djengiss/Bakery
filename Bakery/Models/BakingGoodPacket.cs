using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bakery.Models
{
    public class BakingGoodPacket
    {
        [ForeignKey("GoodId")]
        public int GoodId { get; set; }
        public BakingGood BakingGood { get; set; }

        [ForeignKey("PacketId")]
        public int PacketId { get; set; }
        public Packet Packet { get; set; }
        public int Amount { get; set; }
    }
}