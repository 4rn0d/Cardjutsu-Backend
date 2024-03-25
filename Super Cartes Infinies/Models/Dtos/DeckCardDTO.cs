namespace Super_Cartes_Infinies.Models.Dtos
{
    public class DeckCardDTO
    {
        public int Id { get; set; }
        public Deck Deck { get; set; }
        public List<Card> cards { get; set; }
    }
}
