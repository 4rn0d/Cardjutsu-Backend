using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Services;
using Super_Cartes_Infinies.Services.Interfaces;

namespace Super_Cartes_Infinies.Models
{
	public class Match : IModel
    {
		public Match()
		{
		}

        // Pour créer un nouveau match pour 2 joueurs
        public Match(Player playerA, Player playerB, IEnumerable<Card> cards)
        {
            Id = 0;
            IsMatchCompleted = false;
            UserAId = playerA.IdentityUserId;
            PlayerDataA = new MatchPlayerData(playerA, cards);
            UserBId = playerB.IdentityUserId;
            PlayerDataB = new MatchPlayerData(playerB, cards);
        }

        public int Id { get; set; }
        
        public bool IsPlayerATurn { get; set; } = false;

        public bool IsMatchCompleted { get; set; } = false;

        public string? WinnerUserId { get; set; }
        public string UserAId { get; set; }
        public string UserBId { get; set; }
        public virtual MatchPlayerData PlayerDataA { get; set; }
        public virtual MatchPlayerData PlayerDataB { get; set; }
        [NotMapped]
        public IRandomNumberService RandomNumberService { get; set; }
    }
}

