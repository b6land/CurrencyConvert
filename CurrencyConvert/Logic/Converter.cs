namespace CurrencyConvert.Logic;

/// <summary>
/// 轉換器類別
/// </summary>
public class Converter
{
    /// <summary>
    /// 檢查幣別是否有效
    /// </summary>
    /// <param name="currency"> 幣別名稱 </param>
    /// <returns> 有效則回傳 true，否則回傳 false </returns>
    public bool CheckCurrencyValid(string currency){
        string currencyUpper = currency.ToUpper();
        
        if(currencyUpper == "USD" || currencyUpper == "JPY" || currencyUpper == "TWD"){
            return true;
        }

        return false;
    }

    /// <summary>
    /// 檢查金額是否有效
    /// </summary>
    /// <param name="amount"> 金額 </param>
    /// <returns> 有效則回傳 true，否則回傳 false </returns>
    public bool CheckAmountValid(string amount){
        if(decimal.TryParse(amount.Replace("$", "").Replace(",", ""), out decimal result)){
            return true;
        }
        return false;
    }
    
    /// <summary>
    /// 從不同幣別轉換金額
    /// </summary>
    /// <param name="source"> 來源幣別 </param>
    /// <param name="target"> 目標幣別 </param>
    /// <param name="amount"> 金額 </param>
    /// <returns> 轉換後金額 </returns>
    public decimal CurrencyConvert(string source, string target, string amount){
        double multiple = 1.0;
        
        source = source.ToUpper();
        target = target.ToUpper();

        // 依幣別決定倍率
        switch(source){
            case "USD":
            switch(target){
                case "USD":
                    multiple = 1.0;
                break;                
                case "JPY":
                    multiple = 111.801;
                break;
                case "TWD":
                    multiple = 30.444;
                break;
            }
            break;
            case "JPY":
            switch(target){
                case "USD":
                    multiple = 0.00885;
                break;                
                case "JPY":
                    multiple = 1;
                break;
                case "TWD":
                    multiple = 0.26956;
                break;
            }
            break;
            case "TWD":
            switch(target){
                case "USD":
                    multiple = 0.03281;
                break;                
                case "JPY":
                    multiple = 3.669;
                break;
                case "TWD":
                    multiple = 1;
                break;
            }
            break;
        }
        
        // 剖析與轉換
        amount = amount.Replace(",", "").Replace("$", "");
        double converted = Convert.ToDouble(amount) * multiple;
        return Convert.ToDecimal(converted);
    }
}