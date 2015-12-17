using DTOModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MirasolProxy.Converters
{
    public class CurrencyConverter
    {
        Facade facade = new Facade();
        public double GetCurrencyRate(string currency)
        {
            String URLString = "https://www.ecb.europa.eu/stats/eurofxref/eurofxref-daily.xml?3c2ea957fe3512d296f83170554940b3%22";
            XmlTextReader reader = new XmlTextReader(URLString);
            while (reader.Read())
            {
                reader.MoveToAttribute("rate");

                if (currency == "DKK" && reader.GetAttribute("currency") == "DKK")
                {
                    double dkkRate = double.Parse(reader.Value, CultureInfo.InvariantCulture);
                    return dkkRate;
                }

                else if (currency == "USD" && reader.GetAttribute("currency") == "USD")
                {
                    double usdRate = double.Parse(reader.Value, CultureInfo.InvariantCulture);
                    return usdRate;
                }
            }
            return 1;
        }

        public Prices GetConvertedCurrency(Prices prices, string currency)
        {
            if (prices == null)
            {
                throw new ArgumentNullException("t");
            }

            foreach (var price in facade.GetPricesProxyService().ReadAll())
            {
                if (prices.Id == price.Id)
                {
                    if (currency == "DKK" || currency == "USD")
                    {
                        prices.BeachTowels *= GetCurrencyRate(currency);
                        prices.FinalCleaning *= GetCurrencyRate(currency);
                        prices.HighSeason *= GetCurrencyRate(currency);
                        prices.LinenAndTowels *= GetCurrencyRate(currency);
                        prices.LowSeason *= GetCurrencyRate(currency);
                        prices.MidSeason *= GetCurrencyRate(currency);
                        return prices;
                    }
                }
            }
            return prices;
        }
    }
}
