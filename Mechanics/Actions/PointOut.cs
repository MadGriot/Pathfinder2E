
namespace Pathfinder2E.Mechanics.Actions
{
    public class PointOut : IAction
    {
        public int Id => 10;

        public string Name => "Point Out";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Auditory,
            ActionType.Manipulate,
            ActionType.Visual,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
