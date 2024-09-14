namespace XibalbaAdventure.Models
{
    public class Songweaver : CharacterClass
    {
        public Songweaver() : base(
            "Songweaver",
            "A bard who uses music to inspire allies and weaken enemies.",
            healthBonus: 8,  // Moderate health
            manaBonus: 10)  // Requires mana for performance-based magic
        {
        }
    }
}
