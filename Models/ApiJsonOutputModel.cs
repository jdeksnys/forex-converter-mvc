using System.Collections.Generic;


namespace forex_converter_mvc.Models
{
    public class ApiJsonOutputModel
    {
        public List<Dictionary<string, dynamic>> fx_spot_exchange_rates { get; set; }
        public string unit_currency { get; set; }
    }
}
