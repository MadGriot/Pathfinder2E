namespace Pathfinder2E.Mechanics.Actions
{
    public class MyAction
    {
        public int MyActionId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int CharacterSheetId { get; set; }
        public CharacterSheet characterSheet { get; set; }
        public List<ActionType> traits { get; }

        public virtual void Action(Character character) { }

    }
}
