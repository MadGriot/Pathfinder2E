﻿namespace Pathfinder2E
{
    public class AbilityScore
    {
        public int AbilityScoreId { get; set; }
        public int CharacterSheetId { get; set; }
        public CharacterSheetModel CharacterSheetModel { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}
