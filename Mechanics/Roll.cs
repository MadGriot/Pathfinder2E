namespace Pathfinder2E.Mechanics
{
    public static class Roll
    {

        public static int d20()
        {
            Random random = new Random();

            return random.Next(1, 21);
        }
        public static int d12()
        {
            Random random = new Random();

            return random.Next(1, 13);
        }
        public static int d8()
        {
            Random random = new Random();

            return random.Next(1, 9);
        }
        public static int d6()
        {
            Random random = new Random();

            return random.Next(1, 7);
        }
        public static int d4()
        {
            Random random = new Random();

            return random.Next(1, 7);
        }
        public static int d100()
        {
            Random random = new Random();

            return random.Next(1, 101);
        }

        public static int attack(int bonuses, int penalties, int modifier)
        {
            int attackRoll = d20() + bonuses + penalties + modifier;
            return attackRoll > 0 ? attackRoll : 0;
        }
    }
}
