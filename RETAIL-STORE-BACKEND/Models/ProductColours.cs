﻿namespace RETAIL_STORE_BACKEND.Models
{
    public class ProductColours
    {
        public int? ProductId { get; set; }

        public Product? Product { get; set; }
        public int? ColourId { get; set; }

        public Colour? Colour { get; set; }
    }
}
