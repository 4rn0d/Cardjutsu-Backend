using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayerEndTurnEvent : MatchEvent
    {

        public int PlayerId { get; set; }
        // L'évènement lorsqu'un joueur termine son tour
        public PlayerEndTurnEvent(Match match, MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData)
        {
            
            this.PlayerId = currentPlayerData.PlayerId;
            this.Events = new List<MatchEvent>();

            match.IsPlayerATurn = !match.IsPlayerATurn;


            this.Events.Add(new PlayerStartTurnEvent(opposingPlayerData, 3)); //hardcoded mana -- unable to retrieve manaAmount from matchconfigservice
            
            this.Events.Add(new CombatEvent(currentPlayerData, opposingPlayerData));
        }

    }
}
