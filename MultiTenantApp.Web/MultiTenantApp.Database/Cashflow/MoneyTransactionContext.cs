using Microsoft.EntityFrameworkCore;
using MultiTenantApp.Domain.Cashflow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTenantApp.Database.Cashflow;

public sealed class MoneyTransactionContext(DbContextOptions<MoneyTransactionContext> options) : DbContext(options)
{
    public DbSet<MoneyTransaction> MoneyTransactions { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("TestDb");       
    }
}
