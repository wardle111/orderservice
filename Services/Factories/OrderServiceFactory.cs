using System;
using Microsoft.Extensions.DependencyInjection;
using OrderService.Services;
using OrderService.Services.Factories;

namespace NextPlc.HR.D2D.WebApi.Services
{
    public class OrderServiceFactory : IOrderServiceFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public OrderServiceFactory(IServiceProvider serviceProvider)
        {
            this._serviceProvider = serviceProvider;
        }

        public IOrderService Create()
        {
            return this._serviceProvider.GetRequiredService<OrderService.Services.OrderService>();
        }

        public IOrderService CreateForDryRun()
        {
            return this._serviceProvider.GetRequiredService<OrderService.Services.MockOrderService>();
        }
    }
}