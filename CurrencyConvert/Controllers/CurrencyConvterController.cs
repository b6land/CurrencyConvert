using CurrencyConvert.Logic;
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


    /// <summary>
    /// 傳入來源幣別、目標幣別、金額，取得轉換後金額
    /// </summary>
    /// <param name="source"> 來源幣別 </param>
    /// <param name="target"> 目標幣別 </param>
    /// <param name="amount"> 金額 </param>
    /// <returns> 轉換後金額 </returns>
    [HttpGet(Name = "GetCurrencyConvert")]
    public Currency Get(string source, string target, string amount)
    {
        IExchange exchange = new ExampleExchange();
        Converter conv = new Converter(exchange);
        
        if(!conv.CheckCurrencyValid(source)){
            return new Currency{
                msg = "fail, please correct source currency",
                amount = null
            };
        }
        if(!conv.CheckCurrencyValid(target)){
            return new Currency{
                msg = "fail, please correct target currency",
                amount = null
            };
        }
        if(!conv.CheckAmountValid(amount)){
            return new Currency{
                msg = "fail, please correct amount",
                amount = null
            };
        }

        decimal result = conv.CurrencyConvert(source, target, amount);
        return new Currency{
            msg = "success",
            amount = "$" + result.ToString("N2")
            
        };
    }
}
