using System.ComponentModel.DataAnnotations;

namespace MultiTenantApp.Domain.Cashflow
{
    // Typically I wouldnt use the domain model for my database model but for now it's ok given the scale of the project
    public sealed class MoneyTransaction
    {
        [Key]
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Details { get; set; } = string.Empty;
        public DateTime Date { get; set; }        
        public string AccountNumber { get; set; } = string.Empty;
        public string ReferenceNumber { get; set; } = string.Empty;
    }
}
