
namespace Pathfinder2E.Mechanics
{
    public static class Check
    {
        public static int spell_DC(int modifier, int bonuses, int penalties) =>
            10 + modifier + bonuses + penalties;
        public static int perception(int modifier, int bonuses, int penalties) =>
            Roll.d20() + modifier + bonuses + penalties;
    }
}
