namespace XibalbaAdventure.Models
{
    public class Bloodshaman : CharacterClass
    {
        public Bloodshaman() : base(
            "Bloodshaman",
            "A caster who uses blood magic, often sacrificing health for powerful spells.",
            healthBonus: 8,  // Moderate health, but may sacrifice it for power
            manaBonus: 12)  // High mana for blood rituals and spells
        {
        }
    }
}
