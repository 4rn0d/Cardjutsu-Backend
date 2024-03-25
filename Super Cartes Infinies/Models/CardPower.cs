namespace Super_Cartes_Infinies.Models
{
    public class CardPower
    {
        public int CardPowerId { get; set; }
        public int Value { get; set;}
        public virtual Card Card { get; set; }
        public virtual Power Power { get; set; }
    }
}
