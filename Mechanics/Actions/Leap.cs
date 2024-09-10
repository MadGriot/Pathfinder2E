namespace Pathfinder2E.Mechanics.Actions
{
    public class Leap : IAction
    {
        public int Id => 8;

        public string Name => "Leap";
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
