using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using OrderService.Models;
using OrderService.Services;
using OrderService.Repositories.Orders;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;
        
        private readonly IOrderRepository _orderRepository;

        private readonly IOrderService _orderService;

        public OrderController(ILogger<OrderController> logger, IOrderRepository orderRepository, IOrderService orderService)
        {
            _logger = logger;
            _orderRepository = orderRepository;
            _orderService = orderService;
        }

        [HttpGet("GetOrders")]
        public async Task<IActionResult> GetOrders()
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                var orders = await this._orderRepository.GetOrdersAsync();
                return this.Ok(orders);
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }

        [HttpGet("GetOrder")]
        public async Task<IActionResult> GetOrder()
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                var order = await this._orderRepository.GetOrderAsync();
                return this.Ok(order);
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }

        [HttpGet("GetOrdersByCustomerRef")]
        public async Task<IActionResult> GetOrdersByCustomerRef(int customerRef)
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                var order = await this._orderService.GetOrdersByCustomerAsync(customerRef);
                return this.Ok(order);
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }

        [HttpGet("GetOrder")]
        public async Task<IActionResult> GetOrderByOrderRef(int orderRef)
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called");

            try
            {
                var order = await this._orderRepository.GetOrderByRefAsync(orderRef);
                return this.Ok(order);
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                throw;
            }
        }
    }
}
