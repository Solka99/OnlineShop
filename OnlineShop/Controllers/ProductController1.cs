using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;

namespace OnlineShop.Controllers
{
    [Route("api/product")]
    public class ProductController1 : Controller
    {
        private readonly MyDbContext _myDbContext;

        //public IActionResult Index()
        //{
        //    return View();
        //}
        public ProductController1(MyDbContext myDbContext) 
        {
            _myDbContext = myDbContext;
        }
        public ActionResult<IEnumerable<Product>>GetAll()
        {
            var products=_myDbContext
                .Products
                .ToList();
            return Ok(products);
        }
       // public ActionResult<Product>
    }
}
