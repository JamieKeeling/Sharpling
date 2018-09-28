using FluentAssertions;
using Sharpling.Business;
using System.Threading.Tasks;
using Xunit;

namespace Sharpling.IntegrationTests
{
    public class AccountTests
    {
        [Fact]
        public async Task Account_WithAuth_ReturnsDataAsync()
        {
            var client = new SharplingClient(StarlingEnvironment.SANDBOX, "");

            var account = await client.GetAccountAsync();

            account.Should().NotBeNull();

            account.AccountNumber.Should().NotBeEmpty();
            account.BIC.Should().NotBeEmpty();
            account.CreatedAt.Should().NotBeEmpty();
            account.IBAN.Should().NotBeEmpty();
            account.Id.Should().NotBeEmpty();
            account.Name.Should().NotBeEmpty();
            account.SortCode.Should().NotBeEmpty();
        }

        [Fact]
        public async Task AccountBalance_WithAuth_ReturnsDataAsync()
        {
            var client = new SharplingClient(StarlingEnvironment.SANDBOX, "");

            var accountBalance = await client.GetAccountBalanceAsync();

            accountBalance.Should().NotBeNull();

            accountBalance.ClearedBalance.Should().BePositive();
            accountBalance.EffectiveBalance.Should().BePositive();
            accountBalance.PendingTransactions.Should().BePositive();
            accountBalance.AvailableToSpend.Should().BePositive();
            accountBalance.AcceptedOverdraft.Should().BePositive();
            accountBalance.Currency.Should().NotBeEmpty();
            accountBalance.Amount.Should().BePositive();
        }
    }
}
