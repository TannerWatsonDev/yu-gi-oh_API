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
                    FrameType = "normal",
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
                    FrameType = "normal",
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
                    FrameType = "normal",
                    Description = "A one-eyed behemoth with thick, powerful arms made for delivering punishing blows.",
                    Race = "Beast-Warrior",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1200,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/76184692.jpg"
                },
                new Card
                {
                    Id = 4,
                    CardNumber = "LOB-003",
                    Name = "Flame Swordsman",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Flame Manipulator\" + \"Masaki the Legendary Swordsman\"",
                    Race = "Warrior",
                    Attribute = "FIRE",
                    Level = 5,
                    Atk = 1800,
                    Def = 1600,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/45231177.jpg"
                },
                new Card
                {
                    Id = 5,
                    CardNumber = "LOB-004",
                    Name = "Skull Servant",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A skeletal ghost that isn't strong but can mean trouble in large numbers.",
                    Race = "Zombie",
                    Attribute = "DARK",
                    Level = 1,
                    Atk = 300,
                    Def = 200,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/32274490.jpg"
                },
                new Card
                {
                    Id = 6,
                    CardNumber = "LOB-005",
                    Name = "Dark Magician",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "''The ultimate wizard in terms of attack and defense.''",
                    Race = "Spellcaster",
                    Attribute = "DARK",
                    Level = 7,
                    Atk = 2500,
                    Def = 2100,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/36996508.jpg"
                },
                new Card
                {
                    Id = 7,
                    CardNumber = "LOB-006",
                    Name = "Gaia The Fierce Knight",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "''A knight whose horse travels faster than the wind. His battle-charge is a force to be reckoned with.''",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 7,
                    Atk = 2300,
                    Def = 2100,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/6368038.jpg"
                },
                new Card
                {
                    Id = 8,
                    CardNumber = "LOB-007",
                    Name = "Celtic Guardian",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "An elf who learned to wield a sword, he baffles enemies with lightning-swift attacks.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1400,
                    Def = 1200,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/91152256.jpg"
                },
                new Card
                {
                    Id = 9,
                    CardNumber = "LOB-008",
                    Name = "Basic Insect",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Usually found traveling in swarms, this creature's ideal environment is the forest.",
                    Race = "Insect",
                    Attribute = "EARTH",
                    Level = 2,
                    Atk = 500,
                    Def = 700,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/89091579.jpg"
                },
                new Card
                {
                    Id = 10,
                    CardNumber = "LOB-009",
                    Name = "Mammoth Graveyard",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A mammoth that protects the graves of its pack and is absolutely merciless when facing grave-robbers.",
                    Race = "Dinosaur",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 1200,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/40374923.jpg"
                },
                new Card
                {
                    Id = 11,
                    CardNumber = "LOB-010",
                    Name = "Silver Fang",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A snow wolf that's beautiful to the eye, but absolutely vicious in battle.",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 1200,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/90357090.jpg"
                },
                new Card
                {
                    Id = 12,
                    CardNumber = "LOB-011",
                    Name = "Dark Gray",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Entirely gray, this beast has rarely been seen by mortal eyes.",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 800,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/9159938.jpg"
                },
                new Card
                {
                    Id = 13,
                    CardNumber = "LOB-012",
                    Name = "Trial of Nightmare",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "This fiend passes judgment on enemies that are locked in coffins.",
                    Race = "Fiend",
                    Attribute = "DARK",
                    Level = 4,
                    Atk = 1300,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/77827521.jpg"
                },
                new Card
                {
                    Id = 14,
                    CardNumber = "LOB-013",
                    Name = "Nemuriko",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A child-like creature that controls a sleep fiend to beckon enemies into eternal slumber.",
                    Race = "Spellcaster",
                    Attribute = "DARK",
                    Level = 3,
                    Atk = 800,
                    Def = 700,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/90963488.jpg"
                },
                new Card
                {
                    Id = 15,
                    CardNumber = "LOB-014",
                    Name = "The 13th Grave",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A zombie that suddenly appeared from plot #13 - an empty grave.",
                    Race = "Zombie",
                    Attribute = "DARK",
                    Level = 3,
                    Atk = 1200,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/32864.jpg"
                },
                new Card
                {
                    Id = 16,
                    CardNumber = "LOB-015",
                    Name = "Charubin the Fire Knight",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Monster Egg\" + \"Hinotama Soul\"",
                    Race = "Pyro",
                    Attribute = "FIRE",
                    Level = 3,
                    Atk = 1100,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/37421579.jpg"
                },
                new Card
                {
                    Id = 17,
                    CardNumber = "LOB-016",
                    Name = "Flame Manipulator",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "This Spellcaster attacks enemies with fire-related spells such as \"Sea of Flames\" and \"Wall of Fire\".",
                    Race = "Spellcaster",
                    Attribute = "FIRE",
                    Level = 3,
                    Atk = 900,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/34460851.jpg"
                },
                new Card
                {
                    Id = 18,
                    CardNumber = "LOB-017",
                    Name = "Monster Egg",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A warrior hidden within an egg that attacks enemies by flinging eggshells.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 600,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/36121917.jpg"
                },
                new Card
                {
                    Id = 19,
                    CardNumber = "LOB-018",
                    Name = "Firegrass",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A fire-breathing plant found growing near volcanoes.",
                    Race = "Plant",
                    Attribute = "EARTH",
                    Level = 2,
                    Atk = 700,
                    Def = 600,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/53293545.jpg"
                },
                new Card
                {
                    Id = 20,
                    CardNumber = "LOB-019",
                    Name = "Darkfire Dragon",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Firegrass\" + \"Petit Dragon\"",
                    Race = "Dragon",
                    Attribute = "DARK",
                    Level = 4,
                    Atk = 1500,
                    Def = 1250,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/17881964.jpg"
                },
                new Card
                {
                    Id = 21,
                    CardNumber = "LOB-020",
                    Name = "Dark King of the Abyss",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "It's said that this King of the Netherworld once had the power to rule over the dark.",
                    Race = "Fiend",
                    Attribute = "DARK",
                    Level = 3,
                    Atk = 1200,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/53375573.jpg"
                },
                new Card
                {
                    Id = 22,
                    CardNumber = "LOB-021",
                    Name = "Fiend Reflection #2",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A bird-beast that summons reinforcements with a hand mirror.",
                    Race = "Winged Beast",
                    Attribute = "LIGHT",
                    Level = 4,
                    Atk = 1100,
                    Def = 1400,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/2863439.jpg"
                },
                new Card
                {
                    Id = 23,
                    CardNumber = "LOB-022",
                    Name = "Fusionist",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Petit Angel\" + \"Mystical Sheep #2\"",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 900,
                    Def = 700,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/1641882.jpg"
                },
                new Card
                {
                    Id = 24,
                    CardNumber = "LOB-023",
                    Name = "Turtle Tiger",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A tiger encased in a protective shell that attacks with razor-sharp fangs.",
                    Race = "Aqua",
                    Attribute = "WATER",
                    Level = 4,
                    Atk = 1000,
                    Def = 1500,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/37313348.jpg"
                },
                new Card
                {
                    Id = 25,
                    CardNumber = "LOB-024",
                    Name = "Petit Dragon",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A very small dragon known for its vicious attacks.",
                    Race = "Dragon",
                    Attribute = "WIND",
                    Level = 2,
                    Atk = 600,
                    Def = 700,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/75356564.jpg"
                },
                new Card
                {
                    Id = 26,
                    CardNumber = "LOB-025",
                    Name = "Petit Angel",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A quick-moving and tiny fairy that's very difficult to hit.",
                    Race = "Fairy",
                    Attribute = "LIGHT",
                    Level = 3,
                    Atk = 600,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/38142739.jpg"
                },
                new Card
                {
                    Id = 27,
                    CardNumber = "LOB-026",
                    Name = "Hinotama Soul",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "An intensely hot flame creature that rams anything standing in its way.",
                    Race = "Pyro",
                    Attribute = "FIRE",
                    Level = 2,
                    Atk = 600,
                    Def = 500,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/96851799.jpg"
                },
                new Card
                {
                    Id = 28,
                    CardNumber = "LOB-027",
                    Name = "Aqua Madoor",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A wizard of the waters that conjures a liquid wall to crush any enemies that oppose him.",
                    Race = "Spellcaster",
                    Attribute = "WATER",
                    Level = 4,
                    Atk = 1200,
                    Def = 2000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/85639257.jpg"
                },
                new Card
                {
                    Id = 29,
                    CardNumber = "LOB-028",
                    Name = "Kagemusha of the Blue Flame",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Serving as a double for the Ruler of the Blue Flame, he's a master swordsman that wields a fine blade.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 2,
                    Atk = 800,
                    Def = 400,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/15401633.jpg"
                },
                new Card
                {
                    Id = 30,
                    CardNumber = "LOB-029",
                    Name = "Flame Ghost",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Skull Servant\" + \"Dissolverock\"",
                    Race = "Zombie",
                    Attribute = "DARK",
                    Level = 3,
                    Atk = 1000,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/58528964.jpg"
                },
                new Card
                {
                    Id = 31,
                    CardNumber = "LOB-030",
                    Name = "Two-Mouth Darkruler",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A dinosaur with two deadly jaws, it stores electricity in its horn and releases high voltage bolts from the mouth on its back.",
                    Race = "Dinosaur",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 900,
                    Def = 700,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/57305373.jpg"
                },
                new Card
                {
                    Id = 32,
                    CardNumber = "LOB-031",
                    Name = "Dissolverock",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A monster born in the lava pits, it generates intense heat that can melt away its enemies.",
                    Race = "Rock",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 900,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/40826495.jpg"
                },
                new Card
                {
                    Id = 33,
                    CardNumber = "LOB-032",
                    Name = "Root Water",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "An amphibian capable of calling up a massive tidal wave from the dark seas to wipe out enemy monsters.",
                    Race = "Fish",
                    Attribute = "WATER",
                    Level = 3,
                    Atk = 900,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/39004808.jpg"
                },
                new Card
                {
                    Id = 34,
                    CardNumber = "LOB-033",
                    Name = "The Furious Sea King",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Grand King of the Seven Seas, he's able to summon massive tidal waves to drown the enemy.",
                    Race = "Aqua",
                    Attribute = "WATER",
                    Level = 3,
                    Atk = 800,
                    Def = 700,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/18710707.jpg"
                },
                new Card
                {
                    Id = 35,
                    CardNumber = "LOB-034",
                    Name = "Green Phantom King",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "This youthful king of the forests lives in a green world, abundant with trees and wildlife.",
                    Race = "Plant",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 500,
                    Def = 1600,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/22910685.jpg"
                },
                new Card
                {
                    Id = 36,
                    CardNumber = "LOB-035",
                    Name = "Ray & Temperature",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "The Sun and the North Wind join hands to deliver a devastating combination of heat and gale-force winds.",
                    Race = "Fairy",
                    Attribute = "LIGHT",
                    Level = 3,
                    Atk = 1000,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/85309439.jpg"
                },
                new Card
                {
                    Id = 37,
                    CardNumber = "LOB-036",
                    Name = "King Fog",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A fiend that dwells in a blinding curtain of smoke.",
                    Race = "Fiend",
                    Attribute = "DARK",
                    Level = 3,
                    Atk = 1000,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/84686841.jpg"
                },
                new Card
                {
                    Id = 38,
                    CardNumber = "LOB-037",
                    Name = "Mystical Sheep #2",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A monstrous sheep with a long tail for hypnotizing enemies.",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 800,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/83464209.jpg"
                },
                new Card
                {
                    Id = 39,
                    CardNumber = "LOB-038",
                    Name = "Masaki the Legendary Swordsman",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Legendary swordmaster Masaki is a veteran of over 100 battles.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1100,
                    Def = 1100,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/44287299.jpg"
                },
                new Card
                {
                    Id = 40,
                    CardNumber = "LOB-039",
                    Name = "Kurama",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A vicious bird that attacks from the skies with its whip-like tail.",
                    Race = "Winged Beast",
                    Attribute = "WIND",
                    Level = 3,
                    Atk = 800,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/85705804.jpg"
                },
                new Card
                {
                    Id = 41,
                    CardNumber = "LOB-040",
                    Name = "Legendary Sword",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Equip only to a Warrior monster. It gains 300 ATK/DEF.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/61854111.jpg"
                },
                new Card
                {
                    Id = 42,
                    CardNumber = "LOB-041",
                    Name = "Beast Fangs",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "A Beast-Type monster equipped with this card increases its ATK and DEF by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/46009906.jpg"
                },
                new Card
                {
                    Id = 43,
                    CardNumber = "LOB-042",
                    Name = "Violet Crystal",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "(This card is not treated as a \"Crystal\" card.) Equip only to a Zombie monster. It gains 300 ATK/DEF.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/15052462.jpg"
                },
                new Card
                {
                    Id = 44,
                    CardNumber = "LOB-043",
                    Name = "Book of Secret Arts",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "A Spellcaster-Type monster equipped with this card increases its ATK and DEF by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/91595718.jpg"
                },
                new Card
                {
                    Id = 45,
                    CardNumber = "LOB-044",
                    Name = "Power of Kaishin",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Equip only to an Aqua monster. It gains 300 ATK/DEF.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/77027445.jpg"
                },
                new Card
                {
                    Id = 46,
                    CardNumber = "LOB-045",
                    Name = "Dragon Capture Jar",
                    Type = "Trap Card",
                    FrameType = "trap",
                    Description = "Change all face-up Dragon-Type monsters on the field to Defense Position, also they cannot change their battle positions.",
                    Race = "Continuous",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/50045299.jpg"
                },
                new Card
                {
                    Id = 47,
                    CardNumber = "LOB-046",
                    Name = "Forest",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "All Insect, Beast, Plant, and Beast-Warrior monsters on the field gain 200 ATK/DEF.",
                    Race = "Field",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/87430998.jpg"
                },
                new Card
                {
                    Id = 48,
                    CardNumber = "LOB-047",
                    Name = "Wasteland",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "All Dinosaur, Zombie, and Rock monsters on the field gain 200 ATK/DEF.",
                    Race = "Field",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/23424603.jpg"
                },
                new Card
                {
                    Id = 49,
                    CardNumber = "LOB-048",
                    Name = "Mountain",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "All Dragon, Winged Beast, and Thunder monsters on the field gain 200 ATK/DEF.",
                    Race = "Field",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/50913601.jpg"
                },
                new Card
                {
                    Id = 50,
                    CardNumber = "LOB-049",
                    Name = "Sogen",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "All Warrior and Beast-Warrior monsters on the field gain 200 ATK/DEF.",
                    Race = "Field",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/86318356.jpg"
                },
                new Card
                {
                    Id = 51,
                    CardNumber = "LOB-050",
                    Name = "Umi",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "All Fish, Sea Serpent, Thunder, and Aqua monsters on the field gain 200 ATK/DEF, also all Machine and Pyro monsters on the field lose 200 ATK/DEF.",
                    Race = "Field",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/22702055.jpg"
                },
                new Card
                {
                    Id = 52,
                    CardNumber = "LOB-051",
                    Name = "Yami",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "All Fiend and Spellcaster monsters on the field gain 200 ATK/DEF, also all Fairy monsters on the field lose 200 ATK/DEF.",
                    Race = "Field",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/59197169.jpg"
                },
                new Card
                {
                    Id = 53,
                    CardNumber = "LOB-052",
                    Name = "Dark Hole",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Destroy all monsters on the field.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/53129443.jpg"
                },
                new Card
                {
                    Id = 54,
                    CardNumber = "LOB-053",
                    Name = "Raigeki",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Destroy all monsters your opponent controls.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/12580477.jpg"
                },
                new Card
                {
                    Id = 55,
                    CardNumber = "LOB-054",
                    Name = "Red Medicine",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Increase your Life Points by 500 points.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/38199696.jpg"
                },
                new Card
                {
                    Id = 56,
                    CardNumber = "LOB-055",
                    Name = "Sparks",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Inflict 200 points of damage to your opponent's Life Points.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/76103675.jpg"
                },
                new Card
                {
                    Id = 57,
                    CardNumber = "LOB-056",
                    Name = "Hinotama",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Inflict 500 damage to your opponent.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/46130346.jpg"
                },
                new Card
                {
                    Id = 58,
                    CardNumber = "LOB-057",
                    Name = "Fissure",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Destroy the 1 face-up monster your opponent controls that has the lowest ATK (your choice, if tied).",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/66788016.jpg"
                },
                new Card
                {
                    Id = 59,
                    CardNumber = "LOB-058",
                    Name = "Trap Hole",
                    Type = "Trap Card",
                    FrameType = "trap",
                    Description = "When your opponent Normal or Flip Summons 1 monster with 1000 or more ATK: Target that monster; destroy that target.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/4206964.jpg"
                },
                new Card
                {
                    Id = 60,
                    CardNumber = "LOB-059",
                    Name = "Polymerization",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Fusion Summon 1 Fusion Monster from your Extra Deck, using monsters from your hand or field as Fusion Material.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/24094653.jpg"
                },
                new Card
                {
                    Id = 61,
                    CardNumber = "LOB-060",
                    Name = "Remove Trap",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Select 1 face-up Trap Card on the field and destroy it.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/51482758.jpg"
                },
                new Card
                {
                    Id = 62,
                    CardNumber = "LOB-061",
                    Name = "Two-Pronged Attack",
                    Type = "Trap Card",
                    FrameType = "trap",
                    Description = "Select and destroy 2 of your monsters and 1 of your opponent's monsters.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/83887306.jpg"
                },
                new Card
                {
                    Id = 63,
                    CardNumber = "LOB-062",
                    Name = "Mystical Elf",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A delicate elf that lacks offense, but has a terrific defense backed by mystical power.",
                    Race = "Spellcaster",
                    Attribute = "LIGHT",
                    Level = 4,
                    Atk = 800,
                    Def = 2000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/15025844.jpg"
                },
                new Card
                {
                    Id = 64,
                    CardNumber = "LOB-063",
                    Name = "Tyhone",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Capable of firing cannonballs from its mouth for long-range attacks, this creature is particularly effective in mountain battles.",
                    Race = "Winged Beast",
                    Attribute = "WIND",
                    Level = 4,
                    Atk = 1200,
                    Def = 1400,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/72842870.jpg"
                },
                new Card
                {
                    Id = 65,
                    CardNumber = "LOB-064",
                    Name = "Beaver Warrior",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "What this creature lacks in size it makes up for in defense when battling in the prairie.",
                    Race = "Beast-Warrior",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1200,
                    Def = 1500,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/32452818.jpg"
                },
                new Card
                {
                    Id = 66,
                    CardNumber = "LOB-065",
                    Name = "Gravedigger Ghoul",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Select up to 2 Monster Card(s) from your opponent's Graveyard. Remove the selected card(s) from play.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/82542267.jpg"
                },
                new Card
                {
                    Id = 67,
                    CardNumber = "LOB-066",
                    Name = "Curse of Dragon",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A wicked dragon that taps into dark forces to execute a powerful attack.",
                    Race = "Dragon",
                    Attribute = "DARK",
                    Level = 5,
                    Atk = 2000,
                    Def = 1500,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/28279543.jpg"
                },
                new Card
                {
                    Id = 68,
                    CardNumber = "LOB-067",
                    Name = "Karbonala Warrior",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"M-Warrior #1\" + \"M-Warrior #2\"",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1500,
                    Def = 1200,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/54541900.jpg"
                },
                new Card
                {
                    Id = 69,
                    CardNumber = "LOB-068",
                    Name = "Giant Soldier of Stone",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A giant warrior made of stone. A punch from this creature has earth-shaking results.",
                    Race = "Rock",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 1300,
                    Def = 2000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/13039848.jpg"
                },
                new Card
                {
                    Id = 70,
                    CardNumber = "LOB-069",
                    Name = "Uraby",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Fast on its feet, this dinosaur rips enemies to shreds with its sharp claws.",
                    Race = "Dinosaur",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1500,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/1784619.jpg"
                },
                new Card
                {
                    Id = 71,
                    CardNumber = "LOB-070",
                    Name = "Red-Eyes Black Dragon",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "''A ferocious dragon with a deadly attack.''",
                    Race = "Dragon",
                    Attribute = "DARK",
                    Level = 7,
                    Atk = 2400,
                    Def = 2000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/74677422.jpg"
                },
                new Card
                {
                    Id = 72,
                    CardNumber = "LOB-071",
                    Name = "Reaper of the Cards",
                    Type = "Flip Effect Monster",
                    FrameType = "effect",
                    Description = "FLIP: Select 1 Trap Card on the field and destroy it. If the selected card is Set, pick up and see the card. If it is a Trap Card, it is destroyed. If it is a Spell Card, return it to its original position.",
                    Race = "Fiend",
                    Attribute = "DARK",
                    Level = 5,
                    Atk = 1380,
                    Def = 1930,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/33066139.jpg"
                },
                new Card
                {
                    Id = 73,
                    CardNumber = "LOB-072",
                    Name = "Witty Phantom",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Dressed in a night-black tuxedo, this creature presides over the darkness.",
                    Race = "Fiend",
                    Attribute = "DARK",
                    Level = 4,
                    Atk = 1400,
                    Def = 1300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/36304921.jpg"
                },
                new Card
                {
                    Id = 74,
                    CardNumber = "LOB-073",
                    Name = "Larvas",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A fast-moving, bird-like creature that strangles opposing monsters with its long, thin arms.",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 800,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/94675535.jpg"
                },
                new Card
                {
                    Id = 75,
                    CardNumber = "LOB-074",
                    Name = "Hard Armor",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A living suit of armor that attacks enemies with a bone-jarring tackle.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 300,
                    Def = 1200,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/20060230.jpg"
                },
                new Card
                {
                    Id = 76,
                    CardNumber = "LOB-075",
                    Name = "Man Eater",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Man-eating plant with poison feelers for attacking enemies.",
                    Race = "Plant",
                    Attribute = "EARTH",
                    Level = 2,
                    Atk = 800,
                    Def = 600,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/93553943.jpg"
                },
                new Card
                {
                    Id = 77,
                    CardNumber = "LOB-076",
                    Name = "M-Warrior #1",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Specializing in combination attacks, this warrior uses magnetism to block an enemy's escape.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 1000,
                    Def = 500,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/56342351.jpg"
                },
                new Card
                {
                    Id = 78,
                    CardNumber = "LOB-077",
                    Name = "M-Warrior #2",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Specializing in combination attacks, this warrior is equipped with a tough, magnetically coated armor.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 500,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/92731455.jpg"
                },
                new Card
                {
                    Id = 79,
                    CardNumber = "LOB-078",
                    Name = "Spirit of the Harp",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A spirit that soothes the soul with the music of its heavenly harp.",
                    Race = "Fairy",
                    Attribute = "LIGHT",
                    Level = 4,
                    Atk = 800,
                    Def = 2000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/80770678.jpg"
                },
                new Card
                {
                    Id = 80,
                    CardNumber = "LOB-079",
                    Name = "Armaill",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A strange warrior who manipulates three deadly blades with both hands and his tail.",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 700,
                    Def = 1300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/53153481.jpg"
                },
                new Card
                {
                    Id = 81,
                    CardNumber = "LOB-080",
                    Name = "Terra the Terrible",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Known as a swamp dweller, this creature is a minion of the dark forces.",
                    Race = "Fiend",
                    Attribute = "DARK",
                    Level = 4,
                    Atk = 1200,
                    Def = 1300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/63308047.jpg"
                },
                new Card
                {
                    Id = 82,
                    CardNumber = "LOB-081",
                    Name = "Frenzied Panda",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A savage beast that carries a big bamboo stick for beating down its enemies.",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1200,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/98818516.jpg"
                },
                new Card
                {
                    Id = 83,
                    CardNumber = "LOB-082",
                    Name = "Kumootoko",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A massive, intelligent spider that traps enemies with webbing.",
                    Race = "Insect",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 700,
                    Def = 1400,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/56283725.jpg"
                },
                new Card
                {
                    Id = 84,
                    CardNumber = "LOB-083",
                    Name = "Meda Bat",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "An eyeball fiend created by a servant of the wicked, it uses \"Dark Blasts\" to blow away its enemies.",
                    Race = "Fiend",
                    Attribute = "DARK",
                    Level = 2,
                    Atk = 800,
                    Def = 400,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/76211194.jpg"
                },
                new Card
                {
                    Id = 85,
                    CardNumber = "LOB-084",
                    Name = "Enchanting Mermaid",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A beautiful mermaid that lures voyagers to a watery grave.",
                    Race = "Fish",
                    Attribute = "WATER",
                    Level = 3,
                    Atk = 1200,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/75376965.jpg"
                },
                new Card
                {
                    Id = 86,
                    CardNumber = "LOB-085",
                    Name = "Fireyarou",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A malevolent creature wrapped in flames that attacks enemies with intense fire.",
                    Race = "Pyro",
                    Attribute = "FIRE",
                    Level = 4,
                    Atk = 1300,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/71407486.jpg"
                },
                new Card
                {
                    Id = 87,
                    CardNumber = "LOB-086",
                    Name = "Dragoness the Wicked Knight",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Armaill\" + \"One-Eyed Shield Dragon\"",
                    Race = "Warrior",
                    Attribute = "WIND",
                    Level = 3,
                    Atk = 1200,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/70681994.jpg"
                },
                new Card
                {
                    Id = 88,
                    CardNumber = "LOB-087",
                    Name = "One-Eyed Shield Dragon",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "This dragon wears a shield not only for its own protection, but also for ramming its enemies.",
                    Race = "Dragon",
                    Attribute = "WIND",
                    Level = 3,
                    Atk = 700,
                    Def = 1300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/33064647.jpg"
                },
                new Card
                {
                    Id = 89,
                    CardNumber = "LOB-088",
                    Name = "Dark Energy",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Increase the ATK and DEF of a Fiend-Type monster equipped with this card by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/4614116.jpg"
                },
                new Card
                {
                    Id = 90,
                    CardNumber = "LOB-089",
                    Name = "Laser Cannon Armor",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Equip only to an Insect monster. It gains 300 ATK/DEF.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/77007920.jpg"
                },
                new Card
                {
                    Id = 91,
                    CardNumber = "LOB-090",
                    Name = "Vile Germs",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "A Plant-Type monster equipped with this card increases its ATK and DEF by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/39774685.jpg"
                },
                new Card
                {
                    Id = 92,
                    CardNumber = "LOB-091",
                    Name = "Silver Bow and Arrow",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "A Fairy-Type monster equipped with this card increases its ATK and DEF by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/1557499.jpg"
                },
                new Card
                {
                    Id = 93,
                    CardNumber = "LOB-092",
                    Name = "Dragon Treasure",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "A Dragon-Type monster equipped with this card increases its ATK and DEF by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/1435851.jpg"
                },
                new Card
                {
                    Id = 94,
                    CardNumber = "LOB-093",
                    Name = "Electro-Whip",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Increase the ATK and DEF of a Thunder-Type monster equipped with this card by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/37820550.jpg"
                },
                new Card
                {
                    Id = 95,
                    CardNumber = "LOB-094",
                    Name = "Mystical Moon",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Equip only to a Beast-Warrior-Type monster. It gains 300 ATK and DEF.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/36607978.jpg"
                },
                new Card
                {
                    Id = 96,
                    CardNumber = "LOB-095",
                    Name = "Stop Defense",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Select 1 Defense Position monster on your opponent's side of the field and change it to Attack Position.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/63102017.jpg"
                },
                new Card
                {
                    Id = 97,
                    CardNumber = "LOB-096",
                    Name = "Machine Conversion Factory",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Equip only to a Machine monster. It gains 300 ATK/DEF.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/25769732.jpg"
                },
                new Card
                {
                    Id = 98,
                    CardNumber = "LOB-097",
                    Name = "Raise Body Heat",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Equip only to a Dinosaur monster. It gains 300 ATK/DEF.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/51267887.jpg"
                },
                new Card
                {
                    Id = 99,
                    CardNumber = "LOB-098",
                    Name = "Follow Wind",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Increase the ATK and DEF of a Winged Beast-Type monster equipped with this card by 300 points.",
                    Race = "Equip",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/98252586.jpg"
                },
                new Card
                {
                    Id = 100,
                    CardNumber = "LOB-099",
                    Name = "Goblin's Secret Remedy",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Increase your Life Points by 600 points.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/11868825.jpg"
                },
                new Card
                {
                    Id = 101,
                    CardNumber = "LOB-100",
                    Name = "Final Flame",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Inflict 600 points of damage to your opponent's Life Points.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/73134081.jpg"
                },
                new Card
                {
                    Id = 102,
                    CardNumber = "LOB-101",
                    Name = "Swords of Revealing Light",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "After this card's activation, it remains on the field, but you must destroy it during the End Phase of your opponent's 3rd turn. When this card is activated: If your opponent controls a face-down monster, flip all monsters they control face-up. While this card is face-up on the field, your opponent's monsters cannot declare an attack.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/72302403.jpg"
                },
                new Card
                {
                    Id = 103,
                    CardNumber = "LOB-102",
                    Name = "Metal Dragon",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Steel Ogre Grotto #1\" + \"Lesser Dragon\"",
                    Race = "Machine",
                    Attribute = "WIND",
                    Level = 6,
                    Atk = 1850,
                    Def = 1700,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/9293977.jpg"
                },
                new Card
                {
                    Id = 104,
                    CardNumber = "LOB-103",
                    Name = "Spike Seadra",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Using the spikes sprouting from its body, this creature stabs its opponents and floods them with electricity.",
                    Race = "Sea Serpent",
                    Attribute = "WATER",
                    Level = 5,
                    Atk = 1600,
                    Def = 1300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/85326399.jpg"
                },
                new Card
                {
                    Id = 105,
                    CardNumber = "LOB-104",
                    Name = "Tripwire Beast",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "This creature attacks with electromagnetic waves.",
                    Race = "Thunder",
                    Attribute = "EARTH",
                    Level = 4,
                    Atk = 1200,
                    Def = 1300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/45042329.jpg"
                },
                new Card
                {
                    Id = 106,
                    CardNumber = "LOB-105",
                    Name = "Skull Red Bird",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "This monster swoops down and attacks with a rain of knives stored in its wings.",
                    Race = "Winged Beast",
                    Attribute = "WIND",
                    Level = 4,
                    Atk = 1550,
                    Def = 1200,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/10202894.jpg"
                },
                new Card
                {
                    Id = 107,
                    CardNumber = "LOB-106",
                    Name = "Armed Ninja",
                    Type = "Flip Effect Monster",
                    FrameType = "effect",
                    Description = "FLIP: Target 1 Spell Card on the field; destroy that target. (If the target is Set, reveal it, and destroy it if it is a Spell Card. Otherwise, return it to its original position.)",
                    Race = "Warrior",
                    Attribute = "EARTH",
                    Level = 1,
                    Atk = 300,
                    Def = 300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/9076207.jpg"
                },
                new Card
                {
                    Id = 108,
                    CardNumber = "LOB-107",
                    Name = "Flower Wolf",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Silver Fang\" + \"Darkworld Thorns\"",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 5,
                    Atk = 1800,
                    Def = 1400,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/95952802.jpg"
                },
                new Card
                {
                    Id = 109,
                    CardNumber = "LOB-108",
                    Name = "Man-Eater Bug",
                    Type = "Flip Effect Monster",
                    FrameType = "effect",
                    Description = "FLIP: Target 1 monster on the field; destroy it.",
                    Race = "Insect",
                    Attribute = "EARTH",
                    Level = 2,
                    Atk = 450,
                    Def = 600,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/54652250.jpg"
                },
                new Card
                {
                    Id = 110,
                    CardNumber = "LOB-109",
                    Name = "Sand Stone",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "Appears from underground and attacks with long, snake-like tentacles.",
                    Race = "Rock",
                    Attribute = "EARTH",
                    Level = 5,
                    Atk = 1300,
                    Def = 1600,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/73051941.jpg"
                },
                new Card
                {
                    Id = 111,
                    CardNumber = "LOB-110",
                    Name = "Hane-Hane",
                    Type = "Flip Effect Monster",
                    FrameType = "effect",
                    Description = "FLIP: Select 1 monster on the field and return it to its owner's hand.",
                    Race = "Beast",
                    Attribute = "EARTH",
                    Level = 2,
                    Atk = 450,
                    Def = 500,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/7089711.jpg"
                },
                new Card
                {
                    Id = 112,
                    CardNumber = "LOB-111",
                    Name = "Misairuzame",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A missile-launching fish protected by deadly spikes.",
                    Race = "Fish",
                    Attribute = "WATER",
                    Level = 5,
                    Atk = 1400,
                    Def = 1600,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/33178416.jpg"
                },
                new Card
                {
                    Id = 113,
                    CardNumber = "LOB-112",
                    Name = "Steel Ogre Grotto #1",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A steel idol worshipped in the Land of Machines.",
                    Race = "Machine",
                    Attribute = "EARTH",
                    Level = 5,
                    Atk = 1400,
                    Def = 1800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/29172562.jpg"
                },
                new Card
                {
                    Id = 114,
                    CardNumber = "LOB-113",
                    Name = "Lesser Dragon",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A minor dragon incapable of breathing fire.",
                    Race = "Dragon",
                    Attribute = "WIND",
                    Level = 4,
                    Atk = 1200,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/55444629.jpg"
                },
                new Card
                {
                    Id = 115,
                    CardNumber = "LOB-114",
                    Name = "Darkworld Thorns",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A thorny plant found in the darklands that wraps itself around any unwary traveler.",
                    Race = "Plant",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 1200,
                    Def = 900,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/43500484.jpg"
                },
                new Card
                {
                    Id = 116,
                    CardNumber = "LOB-115",
                    Name = "Drooling Lizard",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A blood-sucking snake in human form that attacks any living being that passes nearby.",
                    Race = "Reptile",
                    Attribute = "EARTH",
                    Level = 3,
                    Atk = 900,
                    Def = 800,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/16353197.jpg"
                },
                new Card
                {
                    Id = 117,
                    CardNumber = "LOB-116",
                    Name = "Armored Starfish",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A bluish starfish with a solid hide capable of fending off attacks.",
                    Race = "Aqua",
                    Attribute = "WATER",
                    Level = 4,
                    Atk = 850,
                    Def = 1400,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/17535588.jpg"
                },
                new Card
                {
                    Id = 118,
                    CardNumber = "LOB-117",
                    Name = "Succubus Knight",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A warrior wizard adept in casting bone-chilling spells.",
                    Race = "Warrior",
                    Attribute = "DARK",
                    Level = 5,
                    Atk = 1650,
                    Def = 1300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/55291359.jpg"
                },
                new Card
                {
                    Id = 119,
                    CardNumber = "LOB-118",
                    Name = "Monster Reborn",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Target 1 monster in either GY; Special Summon it.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/83764718.jpg"
                },
                new Card
                {
                    Id = 120,
                    CardNumber = "LOB-119",
                    Name = "Pot of Greed",
                    Type = "Spell Card",
                    FrameType = "spell",
                    Description = "Draw 2 cards.",
                    Race = "Normal",
                    Attribute = null,
                    Level = null,
                    Atk = null,
                    Def = null,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/55144522.jpg"
                },
                new Card
                {
                    Id = 121,
                    CardNumber = "LOB-120",
                    Name = "Right Leg of the Forbidden One",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A forbidden right leg sealed by magic. Whosoever breaks this seal will know infinite power.",
                    Race = "Spellcaster",
                    Attribute = "DARK",
                    Level = 1,
                    Atk = 200,
                    Def = 300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/8124921.jpg"
                },
                new Card
                {
                    Id = 122,
                    CardNumber = "LOB-121",
                    Name = "Left Leg of the Forbidden One",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A forbidden left leg sealed by magic. Whosoever breaks this seal will know infinite power.",
                    Race = "Spellcaster",
                    Attribute = "DARK",
                    Level = 1,
                    Atk = 200,
                    Def = 300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/44519536.jpg"
                },
                new Card
                {
                    Id = 123,
                    CardNumber = "LOB-122",
                    Name = "Right Arm of the Forbidden One",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A forbidden right arm sealed by magic. Whosoever breaks this seal will know infinite power.",
                    Race = "Spellcaster",
                    Attribute = "DARK",
                    Level = 1,
                    Atk = 200,
                    Def = 300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/70903634.jpg"
                },
                new Card
                {
                    Id = 124,
                    CardNumber = "LOB-123",
                    Name = "Left Arm of the Forbidden One",
                    Type = "Normal Monster",
                    FrameType = "normal",
                    Description = "A forbidden left arm sealed by magic. Whosoever breaks this seal will know infinite power.",
                    Race = "Spellcaster",
                    Attribute = "DARK",
                    Level = 1,
                    Atk = 200,
                    Def = 300,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/7902349.jpg"
                },
                new Card
                {
                    Id = 125,
                    CardNumber = "LOB-124",
                    Name = "Exodia the Forbidden One",
                    Type = "Effect Monster",
                    FrameType = "effect",
                    Description = "If you have \"Right Leg of the Forbidden One\", \"Left Leg of the Forbidden One\", \"Right Arm of the Forbidden One\" and \"Left Arm of the Forbidden One\" in addition to this card in your hand, you win the Duel.",
                    Race = "Spellcaster",
                    Attribute = "DARK",
                    Level = 3,
                    Atk = 1000,
                    Def = 1000,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/33396948.jpg"
                },
                new Card
                {
                    Id = 126,
                    CardNumber = "LOB-125",
                    Name = "Gaia the Dragon Champion",
                    Type = "Fusion Monster",
                    FrameType = "fusion",
                    Description = "\"Gaia The Fierce Knight\" + \"Curse of Dragon\"",
                    Race = "Dragon",
                    Attribute = "WIND",
                    Level = 7,
                    Atk = 2600,
                    Def = 2100,
                    ImageUrl = "https://images.ygoprodeck.com/images/cards/66889139.jpg"
                }
            };
        }
    }
}
