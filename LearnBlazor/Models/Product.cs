﻿namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public decimal Price { get; set; }

        public IEnumerable<Product_Properties> ProdProperties { get; set; }
    }
}
