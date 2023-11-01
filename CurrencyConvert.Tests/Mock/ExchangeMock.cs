public class ExchangeMock : IExchange{
    public double GetMultiple(string source, string target){
        if(source == "USD" && target=="JPY"){
            return 111.801;
        }
        return 1.0;
    }
}