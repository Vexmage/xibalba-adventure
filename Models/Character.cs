namespace XibalbaAdventure.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Kinetic { get; set; }
        public int Concentration { get; set; }
        public int Stoic { get; set; }
        public int Social { get; set; }
        public int Perception { get; set; }

        public Race Race { get; set; }
        public CharacterClass CharacterClass { get; set; }

        // Character-specific attributes
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }

        // Constructor with parameters
        public Character(string name, Race race, CharacterClass characterClass)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;

            // Initialize base stats
            Kinetic = 10;
            Concentration = 10;
            Stoic = 10;
            Social = 10;
            Perception = 10;

            // Apply race and class modifiers
            ApplyRaceModifiers();
            ApplyClassModifiers();
        }

        // Default constructor
        public Character()
        {
            Name = "Default Name";
            Race = new Pentarexian();  // Provide default race
            CharacterClass = new Arquebusier();  // Provide default class

            // Initialize base stats
            Kinetic = 10;
            Concentration = 10;
            Stoic = 10;
            Social = 10;
            Perception = 10;

            // Apply race and class modifiers
            ApplyRaceModifiers();
            ApplyClassModifiers();
        }

        // Apply racial modifiers
        private void ApplyRaceModifiers()
        {
            if (Race != null)
            {
                Kinetic += Race.KineticModifier;
                Concentration += Race.ConcentrationModifier;
                Stoic += Race.StoicModifier;
                Social += Race.SocialModifier;
                Perception += Race.PerceptionModifier;
            }
        }

        // Apply class-based modifiers
        private void ApplyClassModifiers()
        {
            if (CharacterClass != null)
            {
                Health += CharacterClass.HealthBonus;
                Mana += CharacterClass.ManaBonus;
            }
        }
    }
}
