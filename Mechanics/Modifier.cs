using Pathfinder2E.Items;

namespace Pathfinder2E.Mechanics
{
    public class Modifier
    {
        public static int strength_modifier(AbilityScore abilityScore) =>
            (abilityScore.strength - 10) / 2;
        public static int dexterity_modifier(AbilityScore abilityScore) =>
            (abilityScore.dexterity - 10) / 2;
        public static int constitution_modifier(AbilityScore abilityScore) =>
            (abilityScore.constitution - 10) / 2;
        public static int intelligence_modifier(AbilityScore abilityScore) =>
            (abilityScore.intelligence - 10) / 2;
        public static int wisdom_modifier(AbilityScore abilityScore) =>
            (abilityScore.wisdom - 10) / 2;
        public static int charisma_modifier(AbilityScore abilityScore) =>
            (abilityScore.charisma - 10) / 2;
        Armor armor;
        public static int armor_class(int bonuses, int penalties, int modifier) =>
            10 + modifier + penalties + bonuses;

    }
}
