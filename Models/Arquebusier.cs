
namespace XibalbaAdventure.Models
{
    /// <summary>
    /// Represents the Arquebusier class, skilled in firearms and crossbows.
    /// Arquebusiers are tactical soldiers with a focus on ranged weaponry.
    /// </summary>
    public class Arquebusier : CharacterClass
    {
        /// <summary>
        /// Initializes a new instance of the Arquebusier class with predefined health and mana bonuses.
        /// </summary>
        public Arquebusier() : base(
            name: "Arquebusier",
            description: "A soldier skilled with firearms and crossbows.",
            healthBonus: 10,   // Moderate health bonus
            manaBonus: 0)      // No mana, as they do not focus on magic
        {
            // Additional setup or logic specific to Arquebusiers can go here.
        }
    }
}
