namespace Pathfinder2E.Mechanics.Actions
{
    public class Strike : IAction
    {
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Attack,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
