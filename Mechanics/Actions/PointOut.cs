
namespace Pathfinder2E.Mechanics.Actions
{
    public class PointOut : IAction
    {
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Auditory,
            ActionType.Manipulate,
            ActionType.Visual,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
