using OnlineShop.Models;
using System.Collections.Specialized;

namespace OnlineShop
{
    public class OnlineShopSeeder
    {
        private readonly MyDbContext _myDbContext;

        public OnlineShopSeeder(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public void Seed()
        {
            if (_myDbContext.Database.CanConnect())
            {
                if(!_myDbContext.Products.Any()) 
                {
                    var categories=GetCategories();
                    var products = GetProducts();
                    _myDbContext.AddRange(categories);
                    _myDbContext.AddRange(products);
                    if (_myDbContext.SaveChanges() > 0)
                    {
                        Console.WriteLine("Sukces");
                    }
                    else { Console.WriteLine("Porażka"); }
                }
            }
        }
        private IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Name="Coca Cola",
                    Description = "Very yummy drink",
                    Price=3,
                    CategoryID=1,
                    Stock=300
                },
                
            };
            return products;

        }
        private IEnumerable<Category> GetCategories()
        {
            var categories = new List<Category>()
            {
                new Category() {
                    Name = "Drink"
                }
            };
            return categories;
        }
    }
}
