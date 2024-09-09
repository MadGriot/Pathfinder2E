

namespace Pathfinder2E.Mechanics.Actions
{
    public class SenseMotive : IAction
    {
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Concentrate,
            ActionType.Secret,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
