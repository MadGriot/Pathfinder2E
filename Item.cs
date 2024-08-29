namespace Pathfinder2E
{
    public class Item
    {
        public int ItemId { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
        public ItemType Type { get; set; }
        public CharacterSheet CharacterSheet { get; set; }
    }
}
