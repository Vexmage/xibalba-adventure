namespace XibalbaAdventure.Models
{
    public class Daemonist : CharacterClass
    {
        public Daemonist() : base(
            "Daemonist",
            "A caster who communes with demons to wield forbidden magic.",
            healthBonus: 8,  // Moderate health
            manaBonus: 12)  // Strong mana for casting demonic spells
        {
        }
    }
}
