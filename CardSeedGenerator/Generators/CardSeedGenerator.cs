using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardSeedGenerator.Models;

namespace CardSeedGenerator.Generators
{
    internal class SeedCodeGenerator
    {
        public void GenerateCardSeed(List<YgoCard> cards)
        {
            var lobCards = cards
                .Where(c => c.CardSets.Any(s => s.SetCode.StartsWith("LOB")))
                .OrderBy(c => c.CardSets.First(s => s.SetCode.StartsWith("LOB")).SetCode)
                .ToList();

            for (int i = 0; i < lobCards.Count; i++)
            {
                var card = lobCards[i];
                bool isLast = i == lobCards.Count - 1;
                int id = i + 1;

                Console.WriteLine("new Card");

                Console.WriteLine("{");

                Console.WriteLine($"    Id = {id},");

                var lobSet = card.CardSets.FirstOrDefault(s => s.SetCode.StartsWith("LOB"));

                var cardNumber = lobSet?.SetCode ?? card.CardSets[0].SetCode;

                Console.WriteLine($"    CardNumber = \"{cardNumber}\",");

                Console.WriteLine($"    Name = \"{card.Name}\",");

                Console.WriteLine($"    Type = \"{card.Type}\",");

                Console.WriteLine($"    FrameType = \"{card.FrameType}\",");

                var escapedDesc = card.Desc
                                .Replace("\"", "\\\"")
                                .Replace("\r\n", " ")
                                .Replace("\r", " ")
                                .Replace("\n", " ");
                Console.WriteLine($"    Description = \"{escapedDesc}\",");

                Console.WriteLine($"    Race = \"{card.Race}\",");

                Console.WriteLine($"    Attribute = {(card.Attribute != null ? $"\"{card.Attribute}\"" : "null")},");

                Console.WriteLine($"    Level = {(card.Level.HasValue ? card.Level.ToString() : "null")},");

                Console.WriteLine($"    Atk = {(card.Atk.HasValue ? card.Atk.ToString() : "null")},");

                Console.WriteLine($"    Def = {(card.Def.HasValue ? card.Def.ToString() : "null")},");

                Console.WriteLine($"    ImageUrl = \"{card.CardImages[0].ImageUrl}\"");

                Console.WriteLine(isLast ? "}" : "},");
            }
        }
    }
}
