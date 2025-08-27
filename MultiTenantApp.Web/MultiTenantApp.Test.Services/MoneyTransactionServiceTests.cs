using FluentAssertions;
using MultiTenantApp.Services.Transactions;

namespace MultiTenantApp.Test.Services
{
    [TestFixture]
    public class MoneyTransactionServiceTests
    {
        [Test]
        public void GetAllTransactions_ShouldReturnNonEmptyList()
        {
            // Arrange
            var sut = new MoneyTransactionService();

            // Act
            var result = sut.GetAllTransactions();

            // Assert
            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
        }
    }
}