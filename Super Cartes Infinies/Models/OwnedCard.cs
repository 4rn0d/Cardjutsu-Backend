using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace Super_Cartes_Infinies.Models
{
    public class OwnedCard
    {
        public OwnedCard()
        {
        }

        public int Id { get; set; }
        public virtual Player Player { get; set; }
        [ForeignKey("Player")]
        public int PlayerId { get; set; }
        public virtual Card Card { get; set; }
        [ForeignKey("Card")]
        public int CardId { get; set; }

        public virtual List<DeckCard> DeckCards { get; set; }

    }
}
