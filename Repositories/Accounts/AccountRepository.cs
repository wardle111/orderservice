using System;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;


namespace OrderService.Repositories.Accounts
{
    public class AccountRepository : IAccountRepository
    {
        public AccountRepository(ILogger<AccountRepository> logger)
        {
            _logger = logger;
        }

        private ILogger<AccountRepository> _logger { get; set; }

        public Task<bool> CheckAccountExistsAsync(int customerRef)
        {
            this._logger.LogInformation($"Method '{MethodBase.GetCurrentMethod()?.Name}' called by CustomerRef: {customerRef.ToString()}");

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
    }
}
