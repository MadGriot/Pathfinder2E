namespace Pathfinder2E.Mechanics.Actions
{
    public class Stride : IAction
    {

        List<ActionType> IAction.traits => new List<ActionType>()
        {
            ActionType.Move,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
