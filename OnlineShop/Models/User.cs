using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
