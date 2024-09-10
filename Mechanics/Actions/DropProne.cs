namespace Pathfinder2E.Mechanics.Actions
{
    public class DropProne : IAction
    {
        public int Id => 4;

        public string Name => "Drop Prone";
        public string? Description { get => throw new NotImplementedException(); }
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
