﻿using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int Stock { get; set; }
        public Category Category { get; set; }
    }
}
