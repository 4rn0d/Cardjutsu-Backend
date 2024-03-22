using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Super_Cartes_Infinies.Models
{
    public class DeckCard
    {
        
        public int DeckCardId { get; set; }
        [ValidateNever]
        public virtual Deck Deck { get; set; }
        [ValidateNever]
        public virtual Card OwnedCard { get; set; }
    }
}
