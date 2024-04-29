namespace Super_Cartes_Infinies.Models
{
    public class Power
    {

        public int PowerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public bool HasValue { get; set;}

        public const int FIRST_STRIKE_ID = 1;
        public const int THORNS_ID = 2;
        public const int HEAL_ID = 3;
        public const int THIEF_ID = 4;
        public const int BOOST_ATTACK_ID = 5;
        public const int CHAOS_ID = 6;
        public const int RESURECT_ID = 7;
        public const int POISON_ID = 8;
        public const int STUN_ID = 9;
        public const int LIGHTNING_STRIKE_ID = 10;
        public const int EARTHQUAKE_ID = 11;
        public const int RANDOM_PAIN_ID = 12;
    }
}
