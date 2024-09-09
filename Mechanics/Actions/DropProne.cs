namespace Pathfinder2E.Mechanics.Actions
{
    public class DropProne : IAction
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
