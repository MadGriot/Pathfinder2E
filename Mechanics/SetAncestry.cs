namespace Pathfinder2E.Mechanics
{
    public static class SetAncestry
    {
        public static void ResetAbilityScore(Character character)
        {
            character.strength = 10;
            character.dexterity = 10;
            character.constitution = 10;
            character.wisdom = 10;
            character.intelligence = 10;
            character.charisma = 10;
            character.freeBoosts = 0;
        }
        public static void Set(Character character, Ancestry ancestry)
        {
            switch (ancestry)
            {
                case Ancestry.Dwarf:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Dwarf;
                    character.currentHP = 10;
                    character.maxHP = 10;
                    character.size = Size.Medium;
                    character.constitution += 2;
                    character.constitution_modifier = Modifier.attribute_modifier(character.constitution);
                    character.wisdom += 2;
                    character.wisdom_modifier = Modifier.attribute_modifier(character.wisdom);
                    character.charisma -= 2;
                    character.charisma_modifier = Modifier.attribute_modifier(character.charisma);
                    character.freeBoosts += 1;
                    character.speed = 20;
                    break;
                case Ancestry.Elf:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Elf;
                    character.currentHP = 6;
                    character.maxHP = 6;
                    character.size = Size.Medium;
                    character.dexterity += 2;
                    character.dexterity_modifier = Modifier.attribute_modifier(character.dexterity);
                    character.intelligence += 2;
                    character.intelligence_modifier = Modifier.attribute_modifier(character.intelligence);
                    character.constitution -= 2;
                    character.constitution_modifier = Modifier.attribute_modifier(character.constitution);
                    character.freeBoosts += 1;
                    character.speed = 30;
                    break;
                case Ancestry.Gnoll:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Gnoll;
                    character.currentHP = 8;
                    character.maxHP = 8;
                    character.size = Size.Medium;
                    character.strength += 2;
                    character.strength_modifier = Modifier.attribute_modifier(character.strength_modifier);
                    character.intelligence += 2;
                    character.intelligence_modifier = Modifier.attribute_modifier(character.intelligence);
                    character.wisdom -= 2;
                    character.wisdom_modifier = Modifier.attribute_modifier(character.wisdom);
                    character.freeBoosts += 1;
                    character.speed = 25;
                    break;
                case Ancestry.Gnome:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Gnome;
                    character.currentHP = 8;
                    character.maxHP = 8;
                    character.size = Size.Small;
                    character.constitution += 2;
                    character.constitution_modifier = Modifier.attribute_modifier(character.constitution);
                    character.charisma += 2;
                    character.charisma_modifier = Modifier.attribute_modifier(character.charisma);
                    character.strength -= 2;
                    character.strength_modifier = Modifier.attribute_modifier(character.strength);
                    character.freeBoosts += 1;
                    character.speed = 25;
                    break;
                case Ancestry.Goblin:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Goblin;
                    character.currentHP = 6;
                    character.maxHP = 6;
                    character.size = Size.Small;
                    character.dexterity += 2;
                    character.dexterity_modifier = Modifier.attribute_modifier(character.dexterity);
                    character.charisma += 2;
                    character.charisma = Modifier.attribute_modifier(character.charisma);
                    character.wisdom -= 2;
                    character.wisdom_modifier = Modifier.attribute_modifier(character.wisdom);
                    character.freeBoosts += 1;
                    character.speed = 25;
                    break;
                case Ancestry.Halfling:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Halfling;
                    character.currentHP = 6;
                    character.maxHP = 6;
                    character.size = Size.Small;
                    character.dexterity += 2;
                    character.dexterity_modifier = Modifier.attribute_modifier(character.dexterity);
                    character.charisma += 2;
                    character.charisma_modifier = Modifier.attribute_modifier(character.charisma);
                    character.wisdom -= 2;
                    character.wisdom_modifier = Modifier.attribute_modifier(character.wisdom);
                    character.freeBoosts += 1;
                    character.speed = 25;
                    break;
                case Ancestry.Human:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Human;
                    character.currentHP = 8;
                    character.maxHP = 8;
                    character.size = Size.Medium;
                    character.freeBoosts += 2;
                    character.speed = 25;
                    break;
                case Ancestry.Orc:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Human;
                    character.currentHP = 10;
                    character.maxHP = 10;
                    character.size = Size.Medium;
                    character.freeBoosts += 2;
                    character.speed = 25;
                    break;

            }
        }

    }
}
