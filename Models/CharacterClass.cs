namespace XibalbaAdventure.Models
{
    public class CharacterClass
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Class bonuses
        public int HealthBonus { get; set; }
        public int ManaBonus { get; set; }

        // Class-based modifiers for stats (optional)
        public int KineticBonus { get; set; }
        public int ConcentrationBonus { get; set; }
        public int StoicBonus { get; set; }
        public int SocialBonus { get; set; }
        public int PerceptionBonus { get; set; }

        // Constructor
        public CharacterClass(string name, string description, int healthBonus, int manaBonus, int kineticBonus = 0, int concentrationBonus = 0, int stoicBonus = 0, int socialBonus = 0, int perceptionBonus = 0)
        {
            Name = name;
            Description = description;
            HealthBonus = healthBonus;
            ManaBonus = manaBonus;
            KineticBonus = kineticBonus;
            ConcentrationBonus = concentrationBonus;
            StoicBonus = stoicBonus;
            SocialBonus = socialBonus;
            PerceptionBonus = perceptionBonus;
        }
    }
}
