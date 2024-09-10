namespace Pathfinder2E.Mechanics.Actions
{
    public interface IAction
    {
        public int Id { get; }
        public string Name { get; }
        public string? Description { get; }
        public CharacterSheet characterSheet { get; set; }
        public List<ActionType> traits { get; }

        public void Action(Character character);
    }
}
