namespace Pathfinder2E.Mechanics.Actions
{
    internal class Interact : IAction
    {
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Manipulate,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
