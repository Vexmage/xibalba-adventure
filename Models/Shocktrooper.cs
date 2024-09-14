namespace XibalbaAdventure.Models
{
    public class Shocktrooper : CharacterClass
    {
        public Shocktrooper() : base(
            "Shocktrooper",
            "Heavily armored warriors specializing in polearms, capable of enduring hits and controlling the battlefield.",
            healthBonus: 15,  // High health pool for tanking
            manaBonus: 0)  // Focus on physical combat, not magic
        {
        }
    }
}
