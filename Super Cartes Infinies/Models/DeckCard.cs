namespace Super_Cartes_Infinies.Models
{
    public class DeckCard
    {
        public int DeckCardId { get; set; }
        public virtual OwnedCard OwnedCard { get; set; }
    }
}
