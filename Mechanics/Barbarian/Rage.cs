

using Pathfinder2E.Mechanics.Actions;

namespace Pathfinder2E.Mechanics.Barbarian
{
    public class Rage : IAction
    {
        public int Id => 22;

        public string Name => "Rage";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType>()
        {
            ActionType.Barbarian,
            ActionType.Concentrate,
            ActionType.Emotion,
            ActionType.Mental,
        };

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
