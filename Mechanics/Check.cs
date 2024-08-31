
namespace Pathfinder2E.Mechanics
{
    public static class Check
    {
        //I know this is repeated code and I don't care. Go fuck yourself.
        public static int spell_DC(int modifier, int bonuses, int penalties) =>
            10 + modifier + bonuses + penalties;
        public static int perception(int modifier, int bonuses, int penalties) =>
            Roll.d20() + modifier + bonuses + penalties;

        public static int saving_throw(int modifier, int bonuses, int penalties) =>
            Roll.d20() + modifier + bonuses + penalties;

        public static int skill_check(int modifier, int bonuses, int penalties) =>
            Roll.d20() + modifier + bonuses + penalties;

        
    }
}
