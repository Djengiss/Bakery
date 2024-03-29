﻿using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Bakery.Models
{
    public class Packet
    {
        [Key]
        public int PacketId { get; set; }
        public int TrackId { get; set; }
        public List<BakingGoodPacket> BakingGoodsPackets { get; set; }
        //public List<BakingGood> BakingGoods { get; set; }
        public Order Order { get; set; }
    }
}