using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Domain.Cashflow;

namespace MultiTenantApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashflowController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Placeholder for actual cashflow data retrieval logic
            var transactions = new List<MoneyTransaction>
            {
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
            };
            return Ok(transactions);
        }
    }
}
