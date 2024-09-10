


namespace Pathfinder2E.Mechanics.Actions
{
    public class AvertGaze : IAction
    {
        public int Id => 1;

        public string Name => "Avert Gaze";
        public string? Description { get => throw new NotImplementedException(); }

        public List<ActionType> traits => new List<ActionType>();

        public CharacterSheet characterSheet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Action(Character character)
        {
            throw new NotImplementedException();
        }
    }
}
