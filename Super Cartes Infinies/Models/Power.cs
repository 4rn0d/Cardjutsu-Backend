namespace Super_Cartes_Infinies.Models
{
    public class Power
    {
        public const int FIRST_STRIKE_ID = 1;
        public const int THORNS_ID = 2;
        public const int HEAL_ID = 3;
        public const int THIEF_ID = 4; //PLAYER STEALS ENEMY MANA DEPENDING ON POWER VALUE (AFTER THE FIGHT)

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
