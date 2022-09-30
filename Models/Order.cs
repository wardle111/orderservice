using System;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Order
    {
        [Required]
        [StringLength(10)]
        [RegularExpression("[0-9]*", ErrorMessage = "Order Number must consist only of digits.")]
        public int OrderNumber { get; set; }

        public Basket Basket { get; set; }
    }
}
