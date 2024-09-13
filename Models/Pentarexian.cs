


namespace XibalbaAdventure.Models
{
    /// <summary>
    /// Represents the Pentarexian race, humans who settled and conquered the land.
    /// Pentarexians are versatile, gaining small bonuses to Strength and Dexterity.
    /// </summary>
    public class Pentarexian : Race
    {
        /// <summary>
        /// Initializes a new instance of the Pentarexian race with predefined stat modifiers.
        /// </summary>
        public Pentarexian() : base(
            name: "Pentarexian",
            description: "Humans who settled and conquered the land.",
            strMod: 1,      // Small bonus to Strength
            dexMod: 1,      // Small bonus to Dexterity
            conMod: 0,      // No change to Constitution
            intMod: 0,      // No change to Intelligence
            wisMod: 0,      // No change to Wisdom
            chaMod: 0)      // No change to Charisma
        {
            // Additional setup or logic specific to Pentarexians can go here.
        }
    }
}
