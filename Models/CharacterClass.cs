


namespace XibalbaAdventure.Models
{
    public class CharacterClass
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Class bonuses
        public int HealthBonus { get; set; }
        public int ManaBonus { get; set; }

        // Constructor
        public CharacterClass(string name, string description, int healthBonus, int manaBonus)
        {
            Name = name;
            Description = description;
            HealthBonus = healthBonus;
            ManaBonus = manaBonus;
        }
    }
}