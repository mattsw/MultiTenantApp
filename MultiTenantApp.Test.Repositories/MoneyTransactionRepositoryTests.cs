using MultiTenantApp.Repositories.Cashflow;

namespace MultiTenantApp.Test.Repositories;

public class MoneyTransactionRepositoryTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void MoneyTransactionRepository_ShouldInstantiate()
    {
        var sut = new MoneyTransactionRepository();
        Assert.That(sut, Is.Not.Null);
    }
}
