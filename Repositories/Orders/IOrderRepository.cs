using System.Collections.Generic;
using System.Threading.Tasks;
using OrderService.Models;

namespace OrderService.Repositories.Orders
{
    public interface IOrderRepository
    {
        public Task<Order> GetOrderAsync();

        public Task<Order> GetOrderByRefAsync(int orderRef);

        public Task<IEnumerable<Order>> GetOrdersByCustomerRefAsync(int customerRef);

        public Task<IEnumerable<Order>> GetOrdersAsync();
    }
}
