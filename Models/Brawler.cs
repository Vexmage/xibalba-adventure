namespace XibalbaAdventure.Models
{
    public class Brawler : CharacterClass
    {
        public Brawler() : base(
            "Brawler",
            "An unarmed fighter who excels in close combat, using brute force and resilience.",
            healthBonus: 14,  // High health for brawling
            manaBonus: 0)  // Focuses purely on physical combat
        {
        }
    }
}
