


namespace XibalbaAdventure.Models
{
    /// <summary>
    /// Represents the Shocktrooper class, heavily armored warriors specializing in long-reaching weapons.
    /// Shocktroopers are tough, front-line combatants.
    /// </summary>
    public class Shocktrooper : CharacterClass
    {
        /// <summary>
        /// Initializes a new instance of the Shocktrooper class with predefined health and mana bonuses.
        /// </summary>
        public Shocktrooper() : base(
            name: "Shocktrooper",
            description: "Heavily armored Narpaca warriors specializing in long-reaching weapons such as polearms.",
            healthBonus: 15,   // High health bonus
            manaBonus: 0)      // No mana, as they focus on physical combat
        {
            // Additional setup or logic specific to Shocktroopers can go here.
        }
    }
}
