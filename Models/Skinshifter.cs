namespace XibalbaAdventure.Models
{
    public class Skinshifter : CharacterClass
    {
        public Skinshifter() : base(
            "Skinshifter",
            "A shapeshifter who can take on the forms of animals, using their abilities to survive.",
            healthBonus: 10,  // Balanced health pool
            manaBonus: 10)  // Needs mana for shapeshifting abilities
        {
        }
    }
}
