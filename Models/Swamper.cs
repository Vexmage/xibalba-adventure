namespace XibalbaAdventure.Models
{
    public class Swamper : CharacterClass
    {
        public Swamper() : base(
            "Swamper",
            "A survivalist skilled at navigating marshy terrain and thriving in harsh conditions.",
            healthBonus: 12,  // Good health for tough environments
            manaBonus: 5)  // Minor mana for nature-based abilities
        {
        }
    }
}
