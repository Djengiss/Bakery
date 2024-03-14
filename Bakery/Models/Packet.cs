using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class Packet
    {
        [Key]
        public int PacketId { get; set; }
        public int TrackId { get; set; }
        public Dictionary<BakingGood, int> BackingGood { get; set; }
        public Order Order { get; set; }

    }
}
