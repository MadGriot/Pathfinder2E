
namespace Pathfinder2E.Mechanics.Actions
{
    internal class Burrow : IAction
    {
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Move,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
