using Newtonsoft.Json;
using Sharpling.Models.Exceptions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Sharpling.Business.Account
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        private readonly string _authenticationToken;

        public AccountRepository(StarlingEnvironment environment, string authenticationToken) : base(environment)
        {
            _authenticationToken = authenticationToken;
        }

        public async Task<Models.Account> GetAccountAsync()
        {
            if (string.IsNullOrWhiteSpace(_authenticationToken))
            {
                throw new ArgumentException("An authentication token must be presented");
            }

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", _authenticationToken);

                var result = await client.GetAsync($"{BaseEndpoint()}accounts");

                if (!result.IsSuccessStatusCode)
                {
                    throw new StarlingException("HTTP Response indicated failure");
                }

                return JsonConvert.DeserializeObject<Models.Account>(await result.Content.ReadAsStringAsync());
            }
        }
    }
}
