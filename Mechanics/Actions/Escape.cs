namespace Pathfinder2E.Mechanics.Actions
{
    public class Escape : IAction
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
