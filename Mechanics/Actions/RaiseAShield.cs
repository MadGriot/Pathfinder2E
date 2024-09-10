

namespace Pathfinder2E.Mechanics.Actions
{
    public class RaiseAShield : IAction
    {
        public int Id => 11;

        public string Name => "Raise Shield";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType>();

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
