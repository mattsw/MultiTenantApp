using Microsoft.AspNetCore.Mvc;
using MultiTenantApp.Services.Transactions;

namespace MultiTenantApp.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashflowController(IMoneyTransactionService moneyTransactionService) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {            
            return Ok(moneyTransactionService.GetAllTransactions());
        }
    }
}
