using Pathfinder2E.Mechanics;

namespace Pathfinder2E
{
    public class Character
    {
        private int characterId;
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int currentHP { get; set; }
        public int maxHP { get; set; }
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
        public Skills skills { get; set; }
        public Ancestry ancestry { get; set; }
        public Class characterClass { get; set; }
        public Background background { get; set; }
        public Alignment alignment { get; set; }
        public int speed { get; set; }
        public int currentXP { get; set; }
        public int remainingXP { get; set; }
        public Size size { get; set; }
        public int freeBoosts { get; set; }
        public int restrictedBoosts { get; set; }
        public List<Language> languages { get; set; } = new List<Language>();
        public Dictionary<DamageType, int> resistances { get; set; } = new Dictionary<DamageType, int>();
        public Dictionary<DamageType, int> weaknesess { get; set; } = new Dictionary<DamageType, int>();
        public bool inEncounter { get; set; } = false;
        public bool turn { get; set; } = false;
        public int actions { get; set; } = 3;



        public Character(int characterId)
        {
            CharacterSheetDbContext context = new CharacterSheetDbContext();
            this.characterId = characterId;
            CharacterSheet character = context.CharacterSheets
                .First(x => x.CharacterSheetId == characterId);
            AbilityScore abilityScore = context.AbilityScores
                .First(x => x.AbilityScoreId == characterId);
            skills = context.Skills
                .First(x => x.SkillsId == characterId);

            firstName = character.firstName;
            lastName = character.lastName;
            currentHP = character.currentHP;
            maxHP = character.maxHP;
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
            speed = character.speed;
            currentXP = character.XP;
            remainingXP = 1000 - currentXP;
            size = character.size;

            if (character.resistances != null)
            {
                int[] values = character.resistanceValues.ToArray();
                int i = 0;
                foreach (var resistance in character.resistances)
                {
                    resistances.Add(resistance, values[i]);
                    i++;
                }
            }
            if (character.weaknesses != null)
            {
                int[] values = character.weaknessValues.ToArray();
                int i = 0;
                foreach (var weakness in character.weaknesses)
                {
                    weaknesess.Add(weakness, values[i]);
                    i++;
                }
            }
            if (character.languages != null)
            {
                foreach (Language language in character.languages)
                {
                    languages.Add(language);
                }
            }
            }

        public event Action? EndTurn;
        public void consume_action(int points)
        {
            actions -= points;
            if (actions == 0)
            {
                EndTurn.Invoke();
            }
        }
    }
}
