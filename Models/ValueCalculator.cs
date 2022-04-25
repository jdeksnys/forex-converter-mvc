using System;
using System.Collections.Generic;
using System.Linq;


namespace forex_converter_mvc.Models
{
    [Serializable]
    public class ValueCalculator
    {
        public double? Amount { get; set; }
        public string CurrencyFrom { get; set; }
        public string CurrencyTo { get; set; }
        public double? ResultAmount { get; set; }
        public string CF { get; set; }
        public string CT { get; set; }
        public string date { get; set; }


        public static double GetSpecifiedRateTo(List<ExchangeRatesModel> data, string currencyTo)
        {
            var rate = from i in data
                       where i.listed_currency == currencyTo
                       select i.exchange_rate;
            return (double)rate.First();
        }


        public static string GetDate(List<ExchangeRatesModel> data, string currencyTo)
        {
            var date = from j in data
                       where j.listed_currency == currencyTo
                       select j.last_updated_time;
            string dateString = (string)date.First();
            return DateTime.Parse(dateString).ToString("yyyy-MM-dd HH:mm");
        }
    }
}