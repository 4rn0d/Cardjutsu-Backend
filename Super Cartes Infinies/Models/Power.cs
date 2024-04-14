namespace Super_Cartes_Infinies.Models
{
    public class Power
    {

        public int PowerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icone { get; set; }

        public const int FIRST_STRIKE_ID = 1;
        public const int THORNS_ID = 2;
        public const int HEAL_ID = 3;
        public const int THIEF_ID = 4; //PLAYER STEALS ENEMY MANA DEPENDING ON POWER VALUE (AFTER THE FIGHT)
    }
}
