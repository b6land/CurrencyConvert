namespace CurrencyConvert.Models;

/// <summary>
/// 幣別轉換結果類別
/// </summary>
public class Currency
{
    /// <summary>
    /// 轉換結果
    /// </summary>
    public string? msg { get; set; }
    /// <summary>
    /// 轉換後金額
    /// </summary>
    public string? amount { get; set; }
}