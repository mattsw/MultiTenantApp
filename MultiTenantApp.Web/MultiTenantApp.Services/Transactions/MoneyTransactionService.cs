using MultiTenantApp.Domain.Cashflow;
using MultiTenantApp.Repositories.Cashflow;

namespace MultiTenantApp.Services.Transactions
{
    public interface IMoneyTransactionService
    {
        IEnumerable<MoneyTransaction> GetAllTransactions();
    }

    public sealed class MoneyTransactionService(IMoneyTransactionRepository moneyTransactionRepository) : IMoneyTransactionService
    {
        public IEnumerable<MoneyTransaction> GetAllTransactions()
        {

            return moneyTransactionRepository.GetAllTransactions();
        }
    }
}
