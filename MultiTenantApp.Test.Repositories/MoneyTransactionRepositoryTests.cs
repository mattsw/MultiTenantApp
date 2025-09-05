using Microsoft.EntityFrameworkCore;
using MultiTenantApp.Database.Cashflow;
using MultiTenantApp.Repositories.Cashflow;

namespace MultiTenantApp.Test.Repositories;

public class MoneyTransactionRepositoryTests
{
    private MoneyTransactionContext moneyTransactionContext;

    [SetUp]
    public void Setup()
    {
        var mockOptions = new DbContextOptionsBuilder<MoneyTransactionContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString()) // Use a unique in-memory database for each test
            .Options;
        moneyTransactionContext = new MoneyTransactionContext(mockOptions);
    }

    [TearDown]
    public void TearDown()
    {
        moneyTransactionContext.Dispose();
    }

    [Test]
    public void MoneyTransactionRepository_ShouldInstantiate()
    {
        var sut = new MoneyTransactionRepository(moneyTransactionContext);
        Assert.That(sut, Is.Not.Null);
    }
}
