namespace Pathfinder2E.Mechanics.Actions
{
    public class Leap : IAction
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
