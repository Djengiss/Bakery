using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class BakeryBatch
    {
        [Key]
        public int BatchId { get; set; }
        public DateOnly Date { get; set; }
        public int Start_time { get; set; }
        public int Target_end_time { get; set; }
        public int End_time { get; set; }
        public int Amount { get; set; }
        public BakingGood BakingGood { get; set; }
    }
}