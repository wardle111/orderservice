using OrderService.Exceptions;
using OrderService.Models;

namespace NextPlc.HR.D2D.WebApi.Exceptions
{
    public class OrderExistsException : OrderException
    {
        public OrderExistsException(int orderNumber)
            : base(OrderErrorCodes.OrderNotFound)
        {
            this.OrderNumber = orderNumber;
        }

        public int OrderNumber { get; }
    }
}