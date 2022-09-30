using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OrderService.Models;
using OrderService.Utilities;

namespace OrderService.Repositories.Orders
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository(ILogger<OrderRepository> logger)
        {
            _logger = logger;
        }

        private ILogger<OrderRepository> _logger { get; set; }

        public async Task<Order> GetOrderAsync()
        {
            _logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                const string getOrdersUrl = "api/v1/getorders";

                var order = await WebApiClient.CallWebApi(getOrdersUrl);

                return order;

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
                throw new NotImplementedException();
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

        public Task<Order> GetOrderByCustomerRefAsync(int customerRef)
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
