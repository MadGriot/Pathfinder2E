using Pathfinder2E.Mechanics.Actions;

namespace Pathfinder2E.Mechanics.FreeActions
{
    public class Release : IAction
    {
        public int Id => 21;

        public string Name => "Release";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Manipulate,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
