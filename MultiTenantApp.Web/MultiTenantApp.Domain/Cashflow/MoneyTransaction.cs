namespace MultiTenantApp.Domain.Cashflow
{
    public sealed class MoneyTransaction
    {
        public decimal Amount { get; set; }
        public string Details { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public string ReferenceNumber { get; set; } = string.Empty;
    }
}
