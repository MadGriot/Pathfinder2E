

using Pathfinder2E.Mechanics.Actions;

namespace Pathfinder2E.Mechanics.FreeActions
{
    public class Delay : IAction
    {
        public int Id => 20;

        public string Name => "Delay";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType> { };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
