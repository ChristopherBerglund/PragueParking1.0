namespace HotellIsaacChristopher.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public double Price{ get; set; }
        public int GuestID { get; set; }
        public Guest Guest { get; set; }

    }
}