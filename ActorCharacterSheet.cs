using Pathfinder2E.Mechanics;

namespace Pathfinder2E
{
    public class ActorCharacterSheet
    {
        private int CharacterId;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
        public int Strength { get; set; }
        public int StrengthModifier { get; set; }
        public int Dexterity { get; set; }
        public int DexterityModifier { get; set; }

        public int Constitution { get; set; }
        public int ConstitutionModifier { get; set; }
        public int Intelligence { get; set; }
        public int IntelligenceModifier { get; set; }
        public int Wisdom { get; set; }
        public int WisdomModifier { get; set; }
        public int Charisma { get; set; }
        public int CharismaModifier { get; set; }
        public Skills Skills { get; set; }
        public Proficiencies Proficiencies { get; set; }
        public ClassDCs ClassDCs { get; set; }
        public Ancestry Ancestry { get; set; }
        public Class CharacterClass { get; set; }
        public Background Background { get; set; }
        public Alignment Alignment { get; set; }
        public int Speed { get; set; }
        public int CurrentXP { get; set; }
        public int RemainingXP { get; set; }
        public Size Size { get; set; }
        public int FreeBoosts { get; set; }
        public int RestrictedBoosts { get; set; }
        public List<Language> Languages { get; set; } = new List<Language>();
        public Dictionary<DamageType, int> Resistances { get; set; } = new Dictionary<DamageType, int>();
        public Dictionary<DamageType, int> Weaknesess { get; set; } = new Dictionary<DamageType, int>();

        public ActorCharacterSheet()
        {

        }


        public ActorCharacterSheet(int characterId)
        {
            CharacterSheetModelDbContext context = new CharacterSheetModelDbContext();
            CharacterId = characterId;
            CharacterSheetModel character = context.CharacterSheetModels
                .First(x => x.CharacterSheetModelId == characterId);
            AbilityScore abilityScore = context.AbilityScores
                .First(x => x.AbilityScoreId == characterId);
            Skills = context.Skills
                .First(x => x.SkillsId == characterId);
            Proficiencies = character.Proficiencies;
            ClassDCs = character.ClassDCs;

            FirstName = character.FirstName;
            LastName = character.LastName;
            CurrentHP = character.CurrentHP;
            MaxHP = character.MaxHP;
            Strength = abilityScore.Strength;
            StrengthModifier = Modifier.AttributeModifier(Strength);

            Dexterity = abilityScore.Dexterity;
            DexterityModifier = Modifier.AttributeModifier(Dexterity);

            Constitution = abilityScore.Constitution;
            ConstitutionModifier = Modifier.AttributeModifier(Constitution);

            Intelligence = abilityScore.Intelligence;
            IntelligenceModifier = Modifier.AttributeModifier(Intelligence);

            Wisdom = abilityScore.Wisdom;
            WisdomModifier = Modifier.AttributeModifier(Wisdom);

            Charisma = abilityScore.Charisma;
            CharismaModifier = Modifier.AttributeModifier(Charisma);

            Ancestry = character.Ancestry;
            CharacterClass = character.CharacterClass;
            Alignment = character.Alignment;
            Speed = character.Speed;
            CurrentXP = character.XP;
            RemainingXP = 1000 - CurrentXP;
            Size = character.Size;

            if (character.Resistances != null)
            {
                int[] values = character.ResistanceValues.ToArray();
                int i = 0;
                foreach (var resistance in character.Resistances)
                {
                    Resistances.Add(resistance, values[i]);
                    i++;
                }
            }
            if (character.Weaknesses != null)
            {
                int[] values = character.WeaknessValues.ToArray();
                int i = 0;
                foreach (var weakness in character.Weaknesses)
                {
                    Weaknesess.Add(weakness, values[i]);
                    i++;
                }
            }
            if (character.Languages != null)
            {
                foreach (Language language in character.Languages)
                {
                    Languages.Add(language);
                }
            }
         }

    }
}
