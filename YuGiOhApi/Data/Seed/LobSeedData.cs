using YuGiOhApi.Models;

namespace YuGiOhApi.Data.Seed
{
    public static class LobSeedData
    {
        public static List<Card> GetCards()
        {
            return new List<Card>
            {
                new Card
                {
                    Id = 1,
                    CardNumber = "LOB-000",
                    Name = "Tri-Horned Dragon",
                    Type = "Normal Monster",
                    FrameType = "Normal",
                    Description = "An unworthy dragon with three sharp horns sprouting from its head.",
                    Race = "Dragon",
                    Attribute = "DARK",
                    Level = 8,
                    Atk = 2850,
                    Def = 2350,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/39111158.jpg"
                },

                new Card
                {
                    Id = 2,
                    CardNumber = "LOB-001",
                    Name = "Blue-Eyes White Dragon",
                    Type = "Normal Monster",
                    FrameType = "Normal",
                    Description = "This legendary dragon is a powerful engine of destruction. Virtually invincible, very few have faced this awesome creature and lived to tell the tale.",
                    Race = "Dragon",
                    Attribute = "LIGHT",
                    Level = 8,
                    Atk = 3000,
                    Def = 2500,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/89631139.jpg"
                },

                new Card
                {
                    Id = 3,
                    CardNumber = "LOB-002",
                    Name = "Hitotsu-Me Giant",
                    Type = "Normal Monster",
                    FrameType = "Normal",
                    Description = "A one-eyed behemoth with thick, powerful arms made for delivering punishing blows.",
                    Race = "Beast-Warrior",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1200,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards_cropped/76184692.jpg"
                }
            };
        }
    }
}
