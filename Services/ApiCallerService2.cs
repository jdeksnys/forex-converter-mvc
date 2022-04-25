using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using forex_converter_mvc.Models;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace forex_converter_mvc.Services
{
    public class ApiCallerService2
    {
        public HttpClient _client;
        string urlPath { get; set; }



        public ApiCallerService2(HttpClient client)
        {
            this._client = client;
            _client.BaseAddress = new Uri("https://api.sbx.sebgroup.com/");//development
            this.urlPath = "open/fxrates/v3/fx-spot-exchange-rate";//development
        }



        public async Task<List<ExchangeRatesModel>> GetAllRates(string unitCurrency, string listedCurrency=null)
        {
            //_client.DefaultRequestHeaders.Add("unit_currency", unitCurrency);
            urlPath += $"?unit_currency={unitCurrency}";
            if (listedCurrency != null)
            {
                urlPath += $"&listed_currency={listedCurrency}";
            }
            string apiContent = await _client.GetStringAsync(urlPath);

            ApiJsonOutputModel apiContentModel = JsonSerializer.Deserialize<ApiJsonOutputModel>(apiContent);//all of json
            string listToDeserializeAgain = apiContentModel.fx_spot_exchange_rates[0]["fx_spot_mid_exchange_rates"].ToString();//specific part of json

            return JsonSerializer.Deserialize<List<ExchangeRatesModel>>(listToDeserializeAgain);
        }



        public static List<string> listCurrencies(List<ExchangeRatesModel> data)
        {
            List<string> currList = new List<string>();
            foreach (ExchangeRatesModel j in data)
            {
                currList.Add(j.listed_currency);
            }
            return currList;
        }
    }
}
