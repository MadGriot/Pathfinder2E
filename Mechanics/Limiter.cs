

namespace Pathfinder2E.Mechanics
{
    public static class Limiter
    {
        public static bool[] FreeBoostsLimit { get; set; } =
        {
            true,true,true,true,true,true
        };

        public static bool[] RestrictedBoostsLimit { get; set; } =
        {
            false,false,false,false,false,false
        };

        public static void freeBoostReset()
        {
            for (int i = 0; i < FreeBoostsLimit.Length; i++)
            {
                FreeBoostsLimit[i] = true;
            }
        }
        public static void restrictedBoostReset()
        {
            for (int i = 0; i < RestrictedBoostsLimit.Length; i++)
            {
                RestrictedBoostsLimit[i] = false;
            }
        }

        public static void resetSkillValues(Skills skills)
        {
            //fix this

            skills.Acrobatics = 0;
            skills.Arcana = 0;
            skills.Athletics = 0;
            skills.Crafting = 0;
            skills.Deception = 0;
            skills.Diplomacy = 0;
            skills.Intimidation = 0;
            skills.Medicine = 0;
            skills.Nature = 0;
            skills.Occultism = 0;
            skills.Performance = 0;
            skills.Religion = 0;
            skills.Society = 0;
            skills.Stealth = 0;
            skills.Survival = 0;
            skills.Theivery = 0;
        }

    }
}