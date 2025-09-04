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
        throw new NotImplementedException();
    }
}

