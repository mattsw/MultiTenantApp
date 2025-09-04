using MultiTenantApp.Domain.Cashflow;

namespace MultiTenantApp.Repositories.Cashflow;

public interface IMoneyTransactionRepository
{
    IEnumerable<MoneyTransaction> GetAllTransactions();
}

public sealed class MoneyTransactionRepository : IMoneyTransactionRepository
{
    public IEnumerable<MoneyTransaction> GetAllTransactions()
    {

        // Placeholder for actual cashflow data retrieval logic
        return
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
            ];
    }
}

