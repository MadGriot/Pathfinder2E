using Pathfinder2E.Mechanics;

namespace Pathfinder2E
{
    public class Character
    {
        private int characterId;
        public int strength { get; set; }
        public int strength_modifier { get; set; }
        public int dexterity { get; set; }
        public int dexterity_modifier { get; set; }

        public int constitution { get; set; }
        public int constitution_modifier { get; set; }
        public int intelligence { get; set; }
        public int intelligence_modifier { get; set; }
        public int wisdom { get; set; }
        public int wisdom_modifier { get; set; }
        public int charisma { get; set; }
        public int charisma_modifier { get; set; }



        public Character(int characterId)
        {
            CharacterSheetDbContext context = new CharacterSheetDbContext();
            this.characterId = characterId;
            CharacterSheet character = context.Find<CharacterSheet>(characterId);

            strength = character.abilityScore.strength;
            strength_modifier = Modifier.strength_modifier(strength);

            dexterity = character.abilityScore.dexterity;
            dexterity_modifier = Modifier.dexterity_modifier(dexterity);

            constitution = character.abilityScore.constitution;
            constitution_modifier = Modifier.constitution_modifier(constitution);

            intelligence = character.abilityScore.intelligence;
            intelligence_modifier = Modifier.intelligence_modifier(intelligence);

            wisdom = character.abilityScore.wisdom;
            wisdom_modifier = Modifier.wisdom_modifier(wisdom);

            charisma = character.abilityScore.charisma;
            charisma_modifier = Modifier.charisma_modifier(charisma);
        }
    }
}
