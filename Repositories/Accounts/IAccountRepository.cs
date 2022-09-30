using System.Threading.Tasks;

namespace OrderService.Repositories.Accounts
{
    public interface IAccountRepository
    {
        public Task<bool> CheckAccountExistsAsync(int customerRef);
    }
}
