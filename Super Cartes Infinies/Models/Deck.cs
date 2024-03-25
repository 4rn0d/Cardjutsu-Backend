using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Text.Json.Serialization;

namespace Super_Cartes_Infinies.Models
{
    public class Deck
    {
        public int DeckId { get; set; }
        public string DeckName { get; set; }
        public bool IsCurrentDeck { get; set; }
        [ValidateNever]
        public virtual ICollection<DeckCard> DeckCards { get; set; } = new List<DeckCard>();
    }
}
