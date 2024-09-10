
namespace Pathfinder2E.Mechanics.Actions
{
    public class Mount : IAction
    {
        public int Id => 9;

        public string Name => "Mount";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Move
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
