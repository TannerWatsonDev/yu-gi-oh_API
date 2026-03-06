using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CardSeedGenerator.Models
{
    internal class YgoApiResponse
    {
        [JsonPropertyName("data")]
        public required List<YgoCard> Data { get; set; }
    }
}
