﻿using Microsoft.AspNetCore.Mvc;

namespace OnlineShop.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
