using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CardSeedGenerator.Models;

namespace CardSeedGenerator.Models
{
    internal class YgoCard
    {
        public  int Id { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        [JsonPropertyName("frameType")]
        public string? FrameType { get; set; }
        [JsonPropertyName("desc")]
        public required string Desc { get; set; }
        public int? Atk { get; set; }
        public int? Def { get; set; }
        public int? Level { get; set; }
        public required string Race { get; set; }
        public string? Attribute { get; set; }
        [JsonPropertyName("card_sets")]
        public required List<CardSet> CardSets { get; set; }
        [JsonPropertyName("card_images")]
        public required List<CardImage> CardImages { get; set; }
    }
}
