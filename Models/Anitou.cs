namespace XibalbaAdventure.Models
{
    public class Anitou : Race
    {
        public Anitou() : base(
            "Anitou",
            "Mystical deer-like people who live in harmony with nature and are known for their agility and spiritual connection to the land.",
            kineticMod: 1,  // Agile and swift, though not overly strong
            concentrationMod: 2,  // Mystically inclined, they have a high focus on mental acuity
            stoicMod: 0,  // Neutral Stoic modifier
            socialMod: 1,  // Their empathy and connection to others grants them a Social bonus
            perceptionMod: 2)  // Their natural awareness gives them heightened Perception
        {
        }
    }
}
