namespace XibalbaAdventure.Models
{
    public class Hatun : Race
    {
        public Hatun() : base(
            "Hatun",
            "Pachyderm-like, stocky, logical, and musical people from the mountains with a stony appearance and feathered plumes.",
            kineticMod: 2,  // Strong and stocky, they receive a higher Kinetic bonus
            concentrationMod: 1,  // Logical and focused, they get a small bonus to Concentration
            stoicMod: 2,  // Sturdy and resilient, they have a strong Stoic modifier
            socialMod: 0,  // Neutral Social modifier
            perceptionMod: -1)  // Their focus on logic sometimes means they overlook subtleties
        {
        }
    }
}
