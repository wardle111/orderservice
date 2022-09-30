using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using OrderService.Models;

namespace OrderService.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetOrdersByCustomerAsync(int customerRef);
    }
}
