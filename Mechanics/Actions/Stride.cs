namespace Pathfinder2E.Mechanics.Actions
{
    public class Stride : IAction
    {
        public int Id => 17;

        public string Name => "Stride";
        public string? Description { get => throw new NotImplementedException(); }

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
