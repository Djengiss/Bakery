using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class BakeryBatch
    {
        [Key]
        public int BatchId { get; set; }
        public DateOnly Date { get; set; }
        public int StartTime { get; set; }
        public int TargetEndTime { get; set; }
        public int EndTime { get; set; }
        public int Amount { get; set; }
        public BakingGood BakingGood { get; set; }
    }
}