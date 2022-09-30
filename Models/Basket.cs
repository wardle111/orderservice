using System;
using System.Collections.Generic;

namespace OrderService.Models
{
    public class Basket
    {
        public decimal TotalPrice => GetTotalPrice();

        public List<Item> Items => GetItems();

        private decimal _totalPrice;

        private readonly List<Item> _items = new List<Item>();

        private decimal GetTotalPrice()
        {
            foreach (var item in Items)
            {
                _totalPrice = ++ item.Price * item.Quantity;
            }

            return _totalPrice;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        private List<Item> GetItems()
        {
            return _items;
        }
    }
}