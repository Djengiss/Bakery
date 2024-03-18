using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public List<Packet> Packets { get; set; }
        public Address Address { get; set; }
    }
}