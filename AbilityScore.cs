namespace Pathfinder2E
{
    public class AbilityScore
    {
        public int AbilityScoreId { get; set; }
        public int CharacterSheetId { get; set; }
        public CharacterSheet characterSheet { get; set; }
        public int strength { get; set; }
        public int dexterity { get; set; }
        public int constitution { get; set; }
        public int intelligence { get; set; }
        public int wisdom { get; set; }
        public int charisma { get; set; }
    }
}
