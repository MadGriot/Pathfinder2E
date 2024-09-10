namespace Pathfinder2E.Mechanics.Actions
{
    public class Interact : IAction
    {
        public int Id => 7;

        public string Name => "Interact";
        public string? Description { get => throw new NotImplementedException(); }
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
