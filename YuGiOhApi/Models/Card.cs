using System.ComponentModel.DataAnnotations;

namespace YuGiOhApi.Models

{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        public required string CardNumber { get; set; }
        public required string Name { get; set; }
        public required string Type { get; set; }
        public required string FrameType { get; set; }
        public required string Description { get; set; }
        public required string Race { get; set; }
        public string? Attribute { get; set; }
        public int? Level { get; set; }
        public int? Atk { get; set; }
        public int? Def { get; set; }
        public required string ImageUrl { get; set; }

        

    }
}
