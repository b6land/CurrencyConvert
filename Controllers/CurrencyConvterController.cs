using CurrencyConvert.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyConvert.Controllers;

[ApiController]
[Route("[controller]")]
public class CurrencyConvertController : ControllerBase
{
    private readonly ILogger<CurrencyConvertController> _logger;

    public CurrencyConvertController(ILogger<CurrencyConvertController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetCurrencyConvert")]
    public Currency Get(string source, string target, string amount)
    {
        amount = amount.Replace(",", "").Replace("$", "");
        decimal  result = Convert.ToDecimal(amount);
        
        return new Currency{
            msg = "hello",
            amount = "$" + result.ToString("N2")
            
        };
    }
}
