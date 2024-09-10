namespace Pathfinder2E.Mechanics.Actions
{
    public class Ready : IAction
    {
        public int Id => 12;

        public string Name => "Ready";
        public string? Description { get => throw new NotImplementedException(); }
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
