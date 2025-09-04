using MultiTenantApp.Database.Cashflow;
using MultiTenantApp.Repositories.Cashflow;

namespace MultiTenantApp.Test.Repositories;

public class MoneyTransactionRepositoryTests
{
    private MoneyTransactionContext moneyTransactionContext;

    [SetUp]
    public void Setup()
    {
        moneyTransactionContext = new MoneyTransactionContext();
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
