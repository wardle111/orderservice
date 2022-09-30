using System;

namespace OrderService.Models
{
    public class Item
    {
        public string ItemRef { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal Price { get; set; }
    }
}