using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Super_Cartes_Infinies.Models
{
    public class DeckCard
    {
      
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int DeckCardId { get; set; }
      
        [ValidateNever]
        public virtual Card Card { get; set; }
        [ForeignKey("Card")]
        public int CardId { get; set; }
        [ValidateNever]
        public virtual Deck Deck { get; set; }
        [ForeignKey("Deck")]
        public int DeckId { get; set; }
    }
}
