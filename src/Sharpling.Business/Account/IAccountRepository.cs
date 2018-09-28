using System.Threading.Tasks;

namespace Sharpling.Business.Account
{
    public interface IAccountRepository
    {
        Task<Models.Account.Account> GetAccountAsync();
        Task<Models.Account.AccountBalance> GetAccountBalanceAsync();
    }
}