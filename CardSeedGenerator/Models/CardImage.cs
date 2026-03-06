using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace CardSeedGenerator.Models
{
    internal class CardImage
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("image_url")]
        public required string ImageUrl { get; set; }
        [JsonPropertyName("image_url_small")]
        public required string ImageUrlSmall { get; set; }
        [JsonPropertyName("image_url_cropped")]
        public required string ImageUrlCropped { get; set; }
    }
}
