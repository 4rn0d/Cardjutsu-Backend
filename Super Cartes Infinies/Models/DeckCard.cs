using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Super_Cartes_Infinies.Models
{
    public class DeckCard
    {
        
        public int DeckCardId { get; set; }

      
        public int DeckId { get; set; }


        public int OwnedCardId { get; set; }

    }
}
