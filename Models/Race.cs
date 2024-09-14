namespace XibalbaAdventure.Models
{
    public class Race
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // New stat system modifiers
        public int KineticModifier { get; set; }
        public int ConcentrationModifier { get; set; }
        public int StoicModifier { get; set; }
        public int SocialModifier { get; set; }
        public int PerceptionModifier { get; set; }

        // Constructor
        public Race(string name, string description, int kineticMod, int concentrationMod, int stoicMod, int socialMod, int perceptionMod)
        {
            Name = name;
            Description = description;
            KineticModifier = kineticMod;
            ConcentrationModifier = concentrationMod;
            StoicModifier = stoicMod;
            SocialModifier = socialMod;
            PerceptionModifier = perceptionMod;
        }
    }
}
