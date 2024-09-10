namespace Pathfinder2E.Mechanics.Actions
{
    public class Crawl : IAction
    {
        public int Id => 3;

        public string Name => "Crawl";
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
