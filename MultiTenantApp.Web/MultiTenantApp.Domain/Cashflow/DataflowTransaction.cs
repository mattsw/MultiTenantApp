namespace MultiTenantApp.Domain.Cashflow;

public sealed class DataflowTransaction
{
    public int TransactionId { get; set; }
    public string Source { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string Details { get; set; } = string.Empty;
}
