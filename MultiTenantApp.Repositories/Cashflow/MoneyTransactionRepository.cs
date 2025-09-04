using MultiTenantApp.Database.Cashflow;
using MultiTenantApp.Domain.Cashflow;

namespace MultiTenantApp.Repositories.Cashflow;

public interface IMoneyTransactionRepository
{
    IEnumerable<MoneyTransaction> GetAllTransactions();
}

public sealed class MoneyTransactionRepository : IMoneyTransactionRepository
{
    private readonly MoneyTransactionContext _moneyTransactionContext;

    public MoneyTransactionRepository(MoneyTransactionContext moneyTransactionContext)
    {
        _moneyTransactionContext = moneyTransactionContext;
        SeedData(_moneyTransactionContext);
    }

    public IEnumerable<MoneyTransaction> GetAllTransactions()
    {

        return [.. _moneyTransactionContext.MoneyTransactions];
    }

    private void SeedData(MoneyTransactionContext context)
    {
        if (!context.MoneyTransactions.Any())
        {
            context.MoneyTransactions.AddRange(
                new MoneyTransaction
                {
                    Amount = 100.00m,
                    Details = "Sample Transaction 1",
                    Date = DateTime.UtcNow,
                    AccountNumber = "123456789",
                    ReferenceNumber = "REF001"
                },
                new MoneyTransaction
                {
                    Amount = 250.50m,
                    Details = "Sample Transaction 2",
                    Date = DateTime.UtcNow.AddDays(-1),
                    AccountNumber = "987654321",
                    ReferenceNumber = "REF002"
                }
            );
            context.SaveChanges();
        }
    }
}

