namespace XibalbaAdventure.Models
{
    public class Courtier : CharacterClass
    {
        public Courtier() : base(
            "Courtier",
            "A master of social intrigue and diplomacy, skilled at charming and negotiating.",
            healthBonus: 5,  // Relatively low health
            manaBonus: 5)  // Some minor magical or influence-based abilities
        {
        }
    }
}
