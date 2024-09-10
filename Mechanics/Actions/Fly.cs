


namespace Pathfinder2E.Mechanics.Actions
{

    public class Fly : IAction
    {
        public int Id => 6;

        public string Name => "Fly";
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
