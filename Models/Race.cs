


namespace XibalbaAdventure.Models
{
    public class Race
    {
        public string Name { get; set; }
        public string Description { get; set; }

        // Stat Modifiers
        public int StrengthModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int ConstitutionModifier { get; set; }
        public int IntelligenceModifier { get; set; }
        public int WisdomModifier { get; set; }
        public int CharismaModifier { get; set; }

        // Constructor
        public Race(string name, string description, int strMod, int dexMod, int conMod, int intMod, int wisMod, int chaMod)
        {
            Name = name;
            Description = description;
            StrengthModifier = strMod;
            DexterityModifier = dexMod;
            ConstitutionModifier = conMod;
            IntelligenceModifier = intMod;
            WisdomModifier = wisMod;
            CharismaModifier = chaMod;
        }
    }
}
