using FluentAssertions;
using Sharpling.Business;
using Sharpling.Business.Account;
using System;
using System.Threading.Tasks;
using Xunit;

namespace Sharpling.UnitTests
{
    public class AccountRepositoryTests
    {
        [Fact]
        public void AccountRepository_WithBlankAuth_ReturnsArgumentException()
        {
            var accountRepository = new AccountRepository(StarlingEnvironment.SANDBOX, string.Empty);

            Func<Task> action = async () => { await accountRepository.GetAccountAsync(); };
            action.Should().Throw<ArgumentException>().WithMessage("An authentication token must be presented");
        }

        [Fact]
        public void AccountRepository_WithNullAuth_ReturnsArgumentException()
        {
            var accountRepository = new AccountRepository(StarlingEnvironment.SANDBOX, null);

            Func<Task> action = async () => { await accountRepository.GetAccountAsync(); };
            action.Should().Throw<ArgumentException>().WithMessage("An authentication token must be presented");
        }

        [Fact]
        public void AccountRepository_WithWhitespaceAuth_ReturnsArgumentException()
        {
            var accountRepository = new AccountRepository(StarlingEnvironment.SANDBOX, "   ");

            Func<Task> action = async () => { await accountRepository.GetAccountAsync(); };
            action.Should().Throw<ArgumentException>().WithMessage("An authentication token must be presented");
        }
    }
}
