using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MirasolProxy;
using DTOModel;
using System.Reflection;

namespace MirasolTest
{
    [TestClass]
    public class CurrencyTester
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
            Assert.AreEqual(true, ComparePriceChecker(expectedResult, testResult));
        }
        
        public bool ComparePriceChecker(Prices expectedPrice, Prices testPrice)
        {
            Prices price = new Prices();
            PropertyInfo[] arrayOfProperties = price.GetType().GetProperties();
            foreach(var property in arrayOfProperties)
            {
                if (expectedPrice.GetType().GetProperty(property.Name) != testPrice.GetType().GetProperty(property.Name))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
