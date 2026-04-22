namespace TH_502045_2.Models
{
    public class Order
    {
        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public int AgentID { get; set; }

        public virtual Agent Agent { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
