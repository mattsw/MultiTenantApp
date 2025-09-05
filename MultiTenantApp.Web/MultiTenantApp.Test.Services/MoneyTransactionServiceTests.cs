using FluentAssertions;
using Moq;
using MultiTenantApp.Domain.Cashflow;
using MultiTenantApp.Repositories.Cashflow;
using MultiTenantApp.Services.Transactions;

namespace MultiTenantApp.Test.Services
{
    [TestFixture]
    public class MoneyTransactionServiceTests
    {
        private Mock<IMoneyTransactionRepository> moneyTransactionRepository;
        [SetUp]
        public void Setup()
        {
            moneyTransactionRepository = new Mock<IMoneyTransactionRepository>();
            moneyTransactionRepository.Setup(repo => repo.GetAllTransactions())
                .Returns(
                [
                    new() {
                        Amount = 100.00m,
                        Details = "Sample Transaction 1",
                        Date = DateTime.UtcNow,
                        AccountNumber = "123456789",
                        ReferenceNumber = "REF001"
                    },
                    new() {
                        Amount = 250.50m,
                        Details = "Sample Transaction 2",
                        Date = DateTime.UtcNow.AddDays(-1),
                        AccountNumber = "987654321",
                        ReferenceNumber = "REF002"
                    }
                ]);
        }

        [Test]
        public void GetAllTransactions_ShouldReturnNonEmptyList()
        {
            // Arrange
            var sut = new MoneyTransactionService(moneyTransactionRepository.Object);

            // Act
            var result = sut.GetAllTransactions();

            // Assert
            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
        }
    }
}