using Sharpling.Business;
using Sharpling.Business.Account;
using Sharpling.Models;
using System.Threading.Tasks;

namespace Sharpling
{
    public class SharplingClient : IAccountRepository
    {
        private readonly StarlingEnvironment _environment;
        private readonly string _authenticationToken;

        public SharplingClient(StarlingEnvironment environment, string authenticationToken)
        {
            _environment = environment;
            _authenticationToken = authenticationToken;
        }

        public Task<Account> GetAccountAsync()
        {
            //TODO: Figure out DI without muddying the CTOR
            return new AccountRepository(_environment, _authenticationToken).GetAccountAsync();
        }
    }
}
