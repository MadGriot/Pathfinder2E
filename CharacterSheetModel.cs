
using Pathfinder2E.Mechanics;
using Pathfinder2E.Mechanics.Actions;

namespace Pathfinder2E
{
    public class CharacterSheetModel
    {
        public int CharacterSheetModelId { get; set; }
        public int Level { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public Ancestry Ancestry { get; set; }
        public Background Background { get; set; }
        public AbilityScore AbilityScore { get; set; }
        public Skills Skills { get; set; }
        public Proficiencies Proficiencies { get; set; }
        public ClassDCs ClassDCs { get; set; }
        public Class CharacterClass { get; set; }
        public Alignment Alignment { get; set; }
        public Size Size { get; set; }
        public int XP { get; set; }
        public int Speed { get; set; }
        public int FreeBoosts { get; set; }
        public List<Language> Languages { get; set; }
        public ICollection<Feat>? Feats { get; set; }
        public ICollection<Item>? Items { get; set; }
        public List<DamageType>? Weaknesses { get; set; }
        public List<int>? WeaknessValues{ get; set; }
        public List<DamageType>? Resistances { get; set; }
        public List<int>? ResistanceValues { get; set; }

    }
}
