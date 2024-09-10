
namespace Pathfinder2E.Mechanics.Actions
{
    public class Step : IAction
    {
        public int Id => 16;

        public string Name => "Step";
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
