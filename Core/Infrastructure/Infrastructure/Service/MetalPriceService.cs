using Microsoft.Extensions.Configuration;
using System.Net.Http.Json;
 
namespace Infrastructure.Service
{
    public class MetalPriceService : IMetalPriceService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _config;

        public MetalPriceService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }

        public async Task<double> GetGoldOuncePriceAsync()
        {
            var apiKey = _config["MetalApi:Key"];
            var url = $"https://metals-api.com/api/latest?access_key={apiKey}&base=USD&symbols=XAU";
            var response = await _httpClient.GetFromJsonAsync<MetalApiResponse>(url);
            return response?.Rates["XAU"] ?? throw new Exception("No data");
        }

        public async Task<double> GetSilverOuncePriceAsync()
        {
            var apiKey = _config["MetalApi:Key"];
            var url = $"https://metals-api.com/api/latest?access_key={apiKey}&base=USD&symbols=XAG";
            var response = await _httpClient.GetFromJsonAsync<MetalApiResponse>(url);
            return response?.Rates["XAG"] ?? throw new Exception("No data");
        }
    }

    public class MetalApiResponse
    {
        public Dictionary<string, double> Rates { get; set; }
    }

}
