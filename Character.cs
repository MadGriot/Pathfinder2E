using Pathfinder2E.Mechanics;

namespace Pathfinder2E
{
    public class Character
    {
        private int characterId;
        public string firstName { get; set; }
        public string lastName { get; set; }
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
        public Ancestry ancestry { get; }
        public Class characterClass { get; }
        public Alignment alignment { get; set; }



        public Character(int characterId)
        {
            CharacterSheetDbContext context = new CharacterSheetDbContext();
            this.characterId = characterId;
            CharacterSheet character = context.CharacterSheets
                .First(x => x.CharacterSheetId == characterId);
            AbilityScore abilityScore = context.AbilityScores
                .First(x => x.AbilityScoreId == characterId);

            firstName = character.firstName;
            lastName = character.lastName;
            strength = abilityScore.strength;
            strength_modifier = Modifier.attribute_modifier(strength);

            dexterity = abilityScore.dexterity;
            dexterity_modifier = Modifier.attribute_modifier(dexterity);

            constitution = abilityScore.constitution;
            constitution_modifier = Modifier.attribute_modifier(constitution);

            intelligence = abilityScore.intelligence;
            intelligence_modifier = Modifier.attribute_modifier(intelligence);

            wisdom = abilityScore.wisdom;
            wisdom_modifier = Modifier.attribute_modifier(wisdom);

            charisma = abilityScore.charisma;
            charisma_modifier = Modifier.attribute_modifier(charisma);

            ancestry = character.ancestry;
            characterClass = character.characterClass;
            alignment = character.alignment;
        }
    }
}
