using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using CardSeedGenerator.Models;

namespace CardSeedGenerator.Services
{
    internal class CardFetcher
    {
        private const string CardDataUrl = "https://db.ygoprodeck.com/api/v7/cardinfo.php";

        private readonly HttpClient _httpClient;

        public CardFetcher()
        {
            _httpClient = new HttpClient();
        }

        public CardFetcher(HttpClient httpClient)
        {
            _httpClient = httpClient;

        }

        public async Task<List<YgoCard>> FetchCardsBySetAsync(string setName)
        {
            try
            {
                var cardSetUrl = $"{CardDataUrl}?cardset={Uri.EscapeDataString(setName)}";
                var response = await _httpClient.GetAsync(cardSetUrl);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var cardDataResponse = JsonSerializer.Deserialize<YgoApiResponse>(jsonString, options);
                return cardDataResponse?.Data ?? new List<YgoCard>();
            }
            catch (Exception ex)
            {
                 Console.WriteLine($"Error fetching card data: {ex.Message}");
                return new List<YgoCard>();
            }
        }
    }
}
