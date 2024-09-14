namespace XibalbaAdventure.Models
{
    public class Narpaca : Race
    {
        public Narpaca() : base(
            "Narpaca",
            "Large, burly goat-like humanoids who once ruled a great empire before the Pentarexians conquered their lands.",
            kineticMod: 2,  // Physically strong
            concentrationMod: 0,  // Neutral in mental acuity
            stoicMod: 2,  // Resilient and tough
            socialMod: -1,  // Not particularly charming
            perceptionMod: -1)  // Less aware of subtle environmental details
        {
        }
    }
}
