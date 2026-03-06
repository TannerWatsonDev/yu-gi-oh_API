using CardSeedGenerator.Services;
using CardSeedGenerator.Generators;

var cardFetcher = new CardFetcher();
var cards = await cardFetcher.FetchCardsBySetAsync("Legend of Blue Eyes White Dragon");

var seedGenerator = new SeedCodeGenerator();

seedGenerator.GenerateCardSeed(cards);

