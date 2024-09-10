namespace Pathfinder2E.Mechanics.Actions
{
    public class Escape : IAction
    {
        public int Id => 5;

        public string Name => "Escape";
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
