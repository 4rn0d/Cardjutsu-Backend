using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Super_Cartes_Infinies.Services.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Super_Cartes_Infinies.Models
{
    public class Deck :IModel
    {
        public Deck() { }

        public int Id { get; set; }
        public string DeckName { get; set; }
        public bool IsCurrentDeck { get; set; }
        [ValidateNever]
        public virtual List<OwnedCard> OwnedCards { get; set; }
        [ValidateNever]
        public virtual Player Player { get; set; }
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
    }
}
