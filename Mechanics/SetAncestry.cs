namespace Pathfinder2E.Mechanics
{
    public static class SetAncestry
    {


        public static void ResetAbilityScore(CharacterSheet character)
        {
            character.Strength = 10;
            character.Dexterity = 10;
            character.Constitution = 10;
            character.Wisdom = 10;
            character.Intelligence = 10;
            character.Charisma = 10;
            character.FreeBoosts = 0;
        }
        public static void Set(CharacterSheet character, Ancestry Ancestry)
        {
            switch (Ancestry)
            {
                case Ancestry.Dwarf:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Dwarf;
                    character.CurrentHP = 10;
                    character.MaxHP = 10;
                    character.Size = Size.Medium;
                    character.Constitution += 2;
                    character.ConstitutionModifier = Modifier.AttributeModifier(character.Constitution);
                    character.Wisdom += 2;
                    character.WisdomModifier = Modifier.AttributeModifier(character.Wisdom);
                    character.Charisma -= 2;
                    character.CharismaModifier = Modifier.AttributeModifier(character.Charisma);
                    character.FreeBoosts += 1;
                    character.Speed = 20;
                    Limiter.FreeBoostsLimit[2] = false;
                    Limiter.FreeBoostsLimit[3] = false;
                    break;
                case Ancestry.Elf:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Elf;
                    character.CurrentHP = 6;
                    character.MaxHP = 6;
                    character.Size = Size.Medium;
                    character.Dexterity += 2;
                    character.DexterityModifier = Modifier.AttributeModifier(character.Dexterity);
                    character.Intelligence += 2;
                    character.IntelligenceModifier = Modifier.AttributeModifier(character.Intelligence);
                    character.Constitution -= 2;
                    character.ConstitutionModifier = Modifier.AttributeModifier(character.Constitution);
                    character.FreeBoosts += 1;
                    character.Speed = 30;
                    Limiter.FreeBoostsLimit[1] = false;
                    Limiter.FreeBoostsLimit[4] = false;
                    break;
                case Ancestry.Gnoll:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Gnoll;
                    character.CurrentHP = 8;
                    character.MaxHP = 8;
                    character.Size = Size.Medium;
                    character.Strength += 2;
                    character.StrengthModifier = Modifier.AttributeModifier(character.StrengthModifier);
                    character.Intelligence += 2;
                    character.IntelligenceModifier = Modifier.AttributeModifier(character.Intelligence);
                    character.Wisdom -= 2;
                    character.WisdomModifier = Modifier.AttributeModifier(character.Wisdom);
                    character.FreeBoosts += 1;
                    character.Speed = 25;
                    Limiter.FreeBoostsLimit[0] = false;
                    Limiter.FreeBoostsLimit[4] = false;
                    break;
                case Ancestry.Gnome:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Gnome;
                    character.CurrentHP = 8;
                    character.MaxHP = 8;
                    character.Size = Size.Small;
                    character.Constitution += 2;
                    character.ConstitutionModifier = Modifier.AttributeModifier(character.Constitution);
                    character.Charisma += 2;
                    character.CharismaModifier = Modifier.AttributeModifier(character.Charisma);
                    character.Strength -= 2;
                    character.StrengthModifier = Modifier.AttributeModifier(character.Strength);
                    character.FreeBoosts += 1;
                    character.Speed = 25;
                    Limiter.FreeBoostsLimit[2] = false;
                    Limiter.FreeBoostsLimit[5] = false;
                    break;
                case Ancestry.Goblin:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Goblin;
                    character.CurrentHP = 6;
                    character.MaxHP = 6;
                    character.Size = Size.Small;
                    character.Dexterity += 2;
                    character.DexterityModifier = Modifier.AttributeModifier(character.Dexterity);
                    character.Charisma += 2;
                    character.Charisma = Modifier.AttributeModifier(character.Charisma);
                    character.Wisdom -= 2;
                    character.WisdomModifier = Modifier.AttributeModifier(character.Wisdom);
                    character.FreeBoosts += 1;
                    character.Speed = 25;
                    Limiter.FreeBoostsLimit[1] = false;
                    Limiter.FreeBoostsLimit[5] = false;
                    break;
                case Ancestry.Halfling:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Halfling;
                    character.CurrentHP = 6;
                    character.MaxHP = 6;
                    character.Size = Size.Small;
                    character.Dexterity += 2;
                    character.DexterityModifier = Modifier.AttributeModifier(character.Dexterity);
                    character.Charisma += 2;
                    character.CharismaModifier = Modifier.AttributeModifier(character.Charisma);
                    character.Wisdom -= 2;
                    character.WisdomModifier = Modifier.AttributeModifier(character.Wisdom);
                    character.FreeBoosts += 1;
                    character.Speed = 25;
                    Limiter.FreeBoostsLimit[2] = false;
                    Limiter.FreeBoostsLimit[5] = false;
                    break;
                case Ancestry.Human:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Human;
                    character.CurrentHP = 8;
                    character.MaxHP = 8;
                    character.Size = Size.Medium;
                    character.FreeBoosts += 2;
                    character.Speed = 25;
                    break;
                case Ancestry.Orc:
                    ResetAbilityScore(character);
                    character.Ancestry = Ancestry.Human;
                    character.CurrentHP = 10;
                    character.MaxHP = 10;
                    character.Size = Size.Medium;
                    character.FreeBoosts += 2;
                    character.Speed = 25;
                    break;

            }
        }

    }
}
