using System;


namespace forex_converter_mvc.Models
{
    public class ExchangeRatesModel
    {
        public string listed_currency { get; set; }
        public string last_updated_time { get; set; }
        public float exchange_rate { get; set; }
        public float bid_rate { get; set; }
        public float offer_rate { get; set; }
    }
}
