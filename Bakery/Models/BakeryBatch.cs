namespace Bakery.Models
{
    public class BakeryBatch
    {
        public DateOnly Date { get; set; }
        public int Start_time { get; set; }
        public int Target_end_time { get; set; }
        public int End_time { get; set; }
        public int Batch_id { get; set; }
        public int Amount { get; set;}
    }
}
