namespace TH_502045_2.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }

        public int OrderID { get; set; }

        public int ItemID { get; set; }

        public int Quantity { get; set; }

        public uint UnitAmount { get; set; }

        public virtual Order Order { get; set; }

        public virtual Item Item { get; set; }
    }
}
