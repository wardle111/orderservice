namespace OrderService.Services.Factories
{
    public interface IOrderServiceFactory
    {
        public IOrderService Create();

        public IOrderService CreateForDryRun();
    }
}
