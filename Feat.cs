
namespace Pathfinder2E
{
    public class Feat
    {
        public int FeatId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FeatType Type { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
    }
}
