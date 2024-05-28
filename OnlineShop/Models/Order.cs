namespace OnlineShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderedItem> OrderItems { get; set; }
        public User User { get; set; }
    }
}
