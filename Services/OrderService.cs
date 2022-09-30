using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OrderService.Models;
using OrderService.Repositories.Accounts;
using OrderService.Repositories.Orders;

namespace OrderService.Services
{
    public class OrderService : IOrderService
    {
        public OrderService(ILogger<OrderService> logger, IOrderRepository orderRepository, IAccountRepository accountRepository)
        {
            _logger = logger;
            _orderRepository = orderRepository;
        }

        private ILogger<OrderService> _logger { get; set; }

        private IOrderRepository _orderRepository { get; set; }

        private IAccountRepository _accountRepository { get; set; }

        public async Task<Order> GetOrder()
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                return await _orderRepository.GetOrderAsync();

            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }

        public Task<IEnumerable<Order>> GetOrders()
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                throw new System.NotImplementedException();
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }

        public Task<Order> GetOrderByCustomerRef(int customerRef)
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                throw new System.NotImplementedException();
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }

        public IEnumerable<Order> GetOrdersByCustomer(int customerRef)
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                throw new System.NotImplementedException();
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomerAsync(int customerRef)
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                this._logger.LogDebug($"Fetching Order By CustomerRef: {customerRef.ToString()}");

                // Check customer account exists...
                var customerExists = await _accountRepository.CheckAccountExistsAsync(customerRef);

                return customerExists ? await _orderRepository.GetOrdersByCustomerRefAsync(customerRef) : null;
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }
    }
}
