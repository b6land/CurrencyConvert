/// <summary>
/// 匯率類別
/// </summary>
public class ExampleExchange : IExchange{
    /// <summary>
    /// 依幣別決定轉換的匯率
    /// </summary>
    /// <param name="source"> 來源幣別 </param>
    /// <param name="target"> 目標幣別 </param>
    /// <returns> 匯率 </returns>
    public double GetMultiple(string source, string target){
        double multiple = 1;

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
                    multiple = 1.0;
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
                    multiple = 1.0;
                break;
            }
            break;
        }

        return multiple;
    }
}