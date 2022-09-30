using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace OrderService.Repositories.Accounts
{
    public class MockAccountRepository : IAccountRepository
    {
        public MockAccountRepository(ILogger<MockAccountRepository> logger)
        {
            _logger = logger;
        }

        private ILogger<MockAccountRepository> _logger { get; set; }

        public Task<bool> CheckAccountExistsAsync(int customerRef)
        {
            throw new NotImplementedException();
        }
    }
}
