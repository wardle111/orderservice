using System;

namespace OrderService.Exceptions
{
    [Serializable]
    public class OrderException : Exception
    {
        public OrderException(string code)
            : this(code, null)
        {
        }

        public OrderException(string code, string message)
            : base(message)
        {
            this.Code = code;
        }

        public string Code { get; }
    }
}