namespace Pathfinder2E.Mechanics.Actions
{
    public interface IAction
    {
        public List<ActionType> traits { get; }
        public void Action(Character character);
    }
}
