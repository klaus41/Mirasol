using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MirasolProxy;
using DTOModel;
namespace MirasolTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestGetRateDKK()
        {
            double expectedResult = 7.4612;
            double testResult = new Facade().GetCurrencyConverter().GetCurrencyRate("DKK");
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestGetRateUSD()
        {
            double expectedResult = 1.0841;
            double testResult = new Facade().GetCurrencyConverter().GetCurrencyRate("USD");
            Assert.AreEqual(expectedResult, testResult);
        }

        [TestMethod]
        public void TestCurrencyConverterDKK()
        {
            Facade facade = new Facade();
            double rate = facade.GetCurrencyConverter().GetCurrencyRate("DKK");
            Prices expectedPrice = new Prices()
            {
                BeachTowels = 5 * rate,
                FinalCleaning = 80 * rate,
                LinenAndTowels = 12 * rate,
                LowSeason = 530 * rate,
                MidSeason = 695 * rate,
                HighSeason = 895 * rate
            };

            Prices testPrice = new Prices()
            {
                Id = 1,
                BeachTowels = 5,
                FinalCleaning = 80,
                LinenAndTowels = 12,
                LowSeason = 530,
                MidSeason = 695,
                HighSeason = 895
            };

            Prices expectedResult = expectedPrice;
            Prices testResult = facade.GetCurrencyConverter().GetConvertedCurrency(testPrice, "DKK");

            Assert.Equals(expectedPrice, testPrice);
            
        }
    }
}
