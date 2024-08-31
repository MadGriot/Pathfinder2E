
namespace Pathfinder2E.Mechanics
{
    public static class Modifier
    {
        public static int attribute_modifier(int attribute) =>
            (attribute - 10) / 2;
        public static int armor_class(int bonuses, int penalties, int modifier) =>
            10 + modifier + penalties + bonuses;

    }
}
