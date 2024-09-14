namespace XibalbaAdventure.Models
{
    public class Gianthunter : CharacterClass
    {
        public Gianthunter() : base(
            "Gianthunter",
            "A nimble warrior who specializes in taking down large creatures, using agility and precision.",
            healthBonus: 12,  // Decent health for combat
            manaBonus: 0)  // Relies on physical skills over magic
        {
        }
    }
}
