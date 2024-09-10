namespace Pathfinder2E.Mechanics.Actions
{
    public class Stand : IAction
    {
        public int Id => 15;

        public string Name => "Stand";
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
