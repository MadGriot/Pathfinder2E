using Pathfinder2E.Items;

namespace Pathfinder2E.Mechanics
{
    public static class Modifier
    {
        public static int strength_modifier(int strength) =>
            (strength - 10) / 2;
        public static int dexterity_modifier(int dexterity) =>
            (dexterity - 10) / 2;
        public static int constitution_modifier(int constitution) =>
            (constitution - 10) / 2;
        public static int intelligence_modifier(int intelligence) =>
            (intelligence - 10) / 2;
        public static int wisdom_modifier(int wisdom) =>
            (wisdom - 10) / 2;
        public static int charisma_modifier(int charisma) =>
            (charisma - 10) / 2;
        public static int armor_class(int bonuses, int penalties, int modifier) =>
            10 + modifier + penalties + bonuses;

    }
}
