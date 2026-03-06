using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CardSeedGenerator.Models
{
    internal class CardSet
    {
        [JsonPropertyName("set_name")]
        public required string SetName { get; set; }
        [JsonPropertyName("set_code")]
        public required string SetCode { get; set; }
        [JsonPropertyName("set_rarity")]
        public required string Rarity { get; set; }
        [JsonPropertyName("set_rarity_code")]
        public required string RarityCode { get; set; }
        [JsonPropertyName("set_price")]
        public string? SetPrice { get; set; }

    }
}
