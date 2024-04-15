namespace Super_Cartes_Infinies.Models
{
    public class Config
    {
        public Config() { }

        public int Id { get; set; }
        public int NbCardsStart { get; set; }
        public int ManaPerRound { get; set; }
        public int NbDecks {  get; set; }
        public int NbCarteParDeck { get; set; }
    }
}
