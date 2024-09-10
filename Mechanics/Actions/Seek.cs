

namespace Pathfinder2E.Mechanics.Actions
{
    public class Seek : IAction
    {
        public int Id => 13;

        public string Name => "Seek";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType>()
        { ActionType.Concentrate, ActionType.Secret};

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
