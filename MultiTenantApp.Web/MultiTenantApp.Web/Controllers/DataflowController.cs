using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Domain.Cashflow;

namespace MultiTenantApp.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DataflowController : ControllerBase
{
    [HttpGet("status")]
    public IActionResult GetStatus()
    {
        var transactions = new List<DataflowTransaction>
        {
            new() 
            {
                TransactionId = 1,
                Source = "Dataflow A",
                Date = DateTime.UtcNow.AddDays(-1),
                Details = "Transaction details for Dataflow A"
            },
            new() 
            {
                TransactionId = 2,
                Source = "Dataflow B",
                Date = DateTime.UtcNow.AddDays(-2),
                Details = "Transaction details for Dataflow B"
            }
        };
        return Ok(transactions);
    }
}
