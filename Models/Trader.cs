namespace XibalbaAdventure.Models
{
    public class Trader : CharacterClass
    {
        public Trader() : base(
            "Trader",
            "A merchant and negotiator skilled in acquiring goods and making deals.",
            healthBonus: 6,  // Moderate health, not combat-focused
            manaBonus: 5)  // May use minor magic or skills for negotiation
        {
        }
    }
}
