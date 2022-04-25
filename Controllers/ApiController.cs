using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using forex_converter_mvc.Models;
using System.Net.Http;
using forex_converter_mvc.Services;


namespace forex_converter_mvc.Controllers
{
    public class ApiController : Controller
    {
        private readonly ILogger<ApiController> _logger;
        public List<ExchangeRatesModel> data;
        public List<ExchangeRatesModel> genericRequest;
        public string CF;
        public string CT;
        public double rate;



        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }
        public static string? ErrorMessage { get; set; }
        


        public async Task<IActionResult> Exchange([FromServices] ApiCallerService2 apiSvc2)
        {
            ViewBag.CurrenciesFrom = new List<string>() { "AUD", "CHF", "CNY", "DKK", "EUR", "GBP", "JPY", "NOK", "SEK", "USD" };//available option (hardcoded, no request available);

            //populate list for selection
            genericRequest = await apiSvc2.GetAllRates("SEK");
            List<string> availableCurrencies = ApiCallerService.listCurrencies(genericRequest);
            ViewBag.CurrenciesTo = availableCurrencies;

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Exchange(ValueCalculator v, [FromServices] ApiCallerService apiSvc, [FromServices] ApiCallerService2 apiSvc2)//, string currencyFrom, string currencyTo, double amount)
        {
            TempData.Clear();

            try
            {
                data = await apiSvc.GetAllRates(v.CurrencyFrom, v.CurrencyTo);
            }
            catch (HttpRequestException)
            {
                data = await apiSvc2.GetAllRates(v.CurrencyFrom, v.CurrencyTo);
                ErrorMessage = "IMPORTANT! Production API currently unavailable (FOREX market closed on weekends), thus sandbox API called for demonstration.";
            }


            rate = ValueCalculator.GetSpecifiedRateTo(data, v.CurrencyTo);
            if (v.CurrencyFrom == v.CurrencyTo)
            {
                v.ResultAmount = v.Amount;
            }
            else
            {
                decimal toTrunc = (decimal)(v.Amount / rate * 100);
                v.ResultAmount = (double)(Math.Truncate(toTrunc)/ 100);
            }

            v.CF = v.CurrencyFrom;
            v.CT = v.CurrencyTo;
            v.date = ValueCalculator.GetDate(data, v.CurrencyTo);
            TempData.Put("ValueCalculator", v);

            return RedirectToAction("Exchange");
        }
    }
}
