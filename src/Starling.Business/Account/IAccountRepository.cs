using System.Threading.Tasks;

namespace Sharpling.Business.Account
{
    public interface IAccountRepository
    {
        Task<Sharpling.Models.Account> GetAccountAsync();
    }
}