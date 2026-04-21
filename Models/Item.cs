namespace TH_502045_2.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Size { get; set; }

        // Thêm các thuộc tính khác nếu cần (...)

        // Quan hệ 1-N với OrderDetail
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
