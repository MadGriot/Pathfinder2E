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
        public static void Set(Character character)
        {
            switch (character.ancestry)
            {
                case Ancestry.Dwarf:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Dwarf;
                    character.currentHP = 10;
                    character.maxHP = 10;
                    character.constitution += 2;
                    character.wisdom += 2;
                    character.freeBoosts += 1;
                    character.charisma -= 2;
                    character.speed = 20;
                    break;
                case Ancestry.Elf:
                    ResetAbilityScore(character);
                    character.ancestry = Ancestry.Elf;
                    character.currentHP = 6;
                    character.maxHP = 6;
                    character.dexterity += 2;
                    character.intelligence += 2;
                    character.constitution -= 2;
                    character.freeBoosts += 1;
                    character.speed = 20;
                    break;

            }
        }

    }
}
