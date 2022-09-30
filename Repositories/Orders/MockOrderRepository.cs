using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using OrderService.Controllers;
using OrderService.Models;
using OrderService.Repositories.Accounts;

namespace OrderService.Repositories.Orders
{
    public class MockOrderRepository : IOrderRepository
    {
        public MockOrderRepository(ILogger<MockOrderRepository> logger)
        {
            _logger = logger;
        }

        private ILogger<MockOrderRepository> _logger { get; set; }

        public Task<Order> GetOrderAsync()
        {
            _logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                return Task.FromResult(new Order());

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public Task<IEnumerable<Order>> GetOrdersAsync()
        {
            _logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                var orders = new List<Order>
                {
                    new Order()
                    {
                        OrderNumber = 1
                    }
                };

                return Task.FromResult(orders.AsEnumerable());
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public Task<Order> GetOrderByRefAsync(int orderRef)
        {
            _logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }

        public Task<IEnumerable<Order>> GetOrdersByCustomerRefAsync(int customerRef)
        {
            _logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                throw;
            }
        }
    }
}
