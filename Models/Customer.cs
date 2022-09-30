using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderService.Models
{
    public class Customer
    {
        [Required]
        [StringLength(10)]
        public string CustomerRef { get; set; }

        public string CustomerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public List<Order> Orders { get; set; }
    }
}