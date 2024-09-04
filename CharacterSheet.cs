
using Pathfinder2E.Mechanics;

namespace Pathfinder2E
{
    public class CharacterSheet
    {
        public int CharacterSheetId { get; set; }
        public int level { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int currentHP { get; set; }
        public int maxHP { get; set; }
        public Ancestry ancestry { get; set; }
        public Background background { get; set; }
        public AbilityScore abilityScore { get; set; }
        public Class characterClass { get; set; }
        public Alignment alignment { get; set; }
        public Size size { get; set; }
        public int XP { get; set; }
        public int speed { get; set; }
        public int freeBoosts { get; set; }
        public ICollection<Feat>? Feats { get; set; }
        public ICollection<Item>? Items { get; set; }
        public List<DamageType>? weaknesses { get; set; }
        public List<int>? weaknessValues{ get; set; }
        public List<DamageType>? resistances { get; set; }
        public List<int>? resistanceValues { get; set; }

    }
}
