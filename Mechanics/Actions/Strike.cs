namespace Pathfinder2E.Mechanics.Actions
{
    public class Strike : IAction
    {
        public int Id => 18;

        public string Name => "Strike";
        public string? Description { get => throw new NotImplementedException(); }
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
