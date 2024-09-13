

namespace XibalbaAdventure.Models
{
    public class Character
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public Race Race { get; set; }
        public CharacterClass CharacterClass { get; set; }

        // Character-specific attributes
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Level { get; set; }

        // Constructor
        public Character(string name, Race race, CharacterClass characterClass)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;

            // Base stats (modifiers can be applied by Race and Class)
            Strength = 10;
            Dexterity = 10;
            Constitution = 10;
            Intelligence = 10;
            Wisdom = 10;
            Charisma = 10;

            // Set base stats based on race and class
            ApplyRaceModifiers();
            ApplyClassModifiers();
        }

        public Character() { }


        // Apply racial modifiers
        private void ApplyRaceModifiers()
        {
            Strength += Race.StrengthModifier;
            Dexterity += Race.DexterityModifier;
            Constitution += Race.ConstitutionModifier;
            Intelligence += Race.IntelligenceModifier;
            Wisdom += Race.WisdomModifier;
            Charisma += Race.CharismaModifier;
        }

        // Apply class-based modifiers
        private void ApplyClassModifiers()
        {
            Health = CharacterClass.HealthBonus;
            Mana = CharacterClass.ManaBonus;
        }
    }
}
