using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class DispatchRoute
    {
        [Key]
        public int DispatchId { get; set; }
        public List<Address> Addresses { get; set; }
    }
}