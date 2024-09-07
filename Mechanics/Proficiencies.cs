
namespace Pathfinder2E.Mechanics
{
    public class Proficiencies
    {
        public int ProficienciesId { get; set; }
        public int CharacterSheetId { get; set; }
        public CharacterSheet characterSheet { get; set; }
        public int Advanced_Weapons { get; set; }
        public int Alchemical_bombs { get; set; }
        public int Divine_Spell_Attacks { get; set; }
        public int Divine_Spell_DC { get; set; }
        public int Fortitude { get; set; }
        public int Heavy_Armor { get; set; }
        public int Light_Armor { get; set; }
        public int Longsword { get; set; }
        public int Martial_Weapons { get; set; }
        public int Medium_Armor { get; set; }
        public int Occult_Spell_DCs { get; set; }
        public int Occult_Spell_Attacks { get; set; }
        public int Perception { get; set; }
        public int Rapier { get; set; }
        public int Reflex { get; set; }
        public int Sap { get; set; }
        public int Shortbow { get; set; }
        public int Shortsword { get; set; }
        public int Simple_Weapons { get; set; }
        public int Unarmed_Attacks { get; set; }
        public int Unarmored_Defence { get; set; }
        public int Will { get; set; }
    }
}