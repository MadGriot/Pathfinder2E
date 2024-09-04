

namespace Pathfinder2E.Mechanics
{
    public static class Limiter
    {
        public static bool[] freeBoostsLimit { get; set; } =
{
            true,true,true,true,true,true
        };

        public static bool[] restrictedBoostsLimit { get; set; } =
        {
            false,false,false,false,false,false
        }
    }
}
