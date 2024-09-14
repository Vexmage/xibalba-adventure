namespace XibalbaAdventure.Models
{
    public class Phalanxer : CharacterClass
    {
        public Phalanxer() : base(
            "Phalanxer",
            "A defensive warrior skilled in using shields and formation fighting, excelling in group tactics.",
            healthBonus: 14,  // High health for front-line fighting
            manaBonus: 0)  // Focus on physical combat over magic
        {
        }
    }
}
