namespace XibalbaAdventure.Models
{
    public class Arquebusier : CharacterClass
    {
        public Arquebusier() : base(
            "Arquebusier",
            "A soldier skilled with firearms and crossbows, excelling in ranged combat.",
            healthBonus: 10,  // Solid health pool
            manaBonus: 0)  // Does not rely on mana
        {
        }
    }
}
