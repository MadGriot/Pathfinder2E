
namespace Pathfinder2E.Mechanics.Actions
{
    internal class Burrow : IAction
    {
        public int Id => 2;

        public string Name => "Burrow";
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
