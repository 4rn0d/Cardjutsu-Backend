using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Super_Cartes_Infinies.Models
{
    public class Deck
    {
        public int DeckId { get; set; }
        public string DeckName { get; set; }
        public bool IsCurrentDeck { get; set; }
        [ValidateNever]
        public virtual List<DeckCard> DeckCards { get; set; }
    }
}
