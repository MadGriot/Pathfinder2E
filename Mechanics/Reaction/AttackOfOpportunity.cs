using Pathfinder2E.Mechanics.Actions;


namespace Pathfinder2E.Mechanics.Reaction
{
    public class AttackOfOpportunity : IAction
    {
        public int Id => 22;

        public string Name => "Attack Of Opportunity";
        public string? Description { get => throw new NotImplementedException(); }
        public List<ActionType> traits => new List<ActionType>();

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
