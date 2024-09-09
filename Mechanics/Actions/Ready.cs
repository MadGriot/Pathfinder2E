namespace Pathfinder2E.Mechanics.Actions
{
    public class Ready : IAction
    {
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Concentrate,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
