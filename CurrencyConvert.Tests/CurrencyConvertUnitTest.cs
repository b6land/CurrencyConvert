namespace CurrencyConvert.Tests;
using CurrencyConvert.Logic;

[TestClass]
public class CurrencyConvertUnitTest
{
    [TestMethod]
    public void 正確幣別與金額的轉換()
    {
        Converter conv = new Converter(new ExchangeMock());
        decimal result = conv.CurrencyConvert("USD", "JPY", "$1,525");
        Assert.AreEqual(result, 170496.525M);
    }
}