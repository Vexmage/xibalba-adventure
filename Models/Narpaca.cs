


namespace XibalbaAdventure.Models
{
    /// <summary>
    /// Represents the Narpaca race, large goat-like humanoids who once ruled a great empire.
    /// Narpaca are physically powerful, gaining significant bonuses to Strength and Constitution, 
    /// but are less intelligent and charismatic.
    /// </summary>
    public class Narpaca : Race
    {
        /// <summary>
        /// Initializes a new instance of the Narpaca race with predefined stat modifiers.
        /// </summary>
        public Narpaca() : base(
            name: "Narpaca",
            description: "Large, burly goat-like humanoids who once ruled a great empire before the Pentarexians conquered their lands.",
            strMod: 2,      // Significant bonus to Strength
            dexMod: 0,      // No change to Dexterity
            conMod: 2,      // Significant bonus to Constitution
            intMod: -1,     // Penalty to Intelligence
            wisMod: 0,      // No change to Wisdom
            chaMod: -1)     // Penalty to Charisma
        {
            // Additional setup or logic specific to Narpaca can go here.
        }
    }
}
