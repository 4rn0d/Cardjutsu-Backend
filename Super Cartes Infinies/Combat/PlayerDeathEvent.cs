using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayerDeathEvent : MatchEvent
    {

        public int WinningPlayerId { get; set; }

        public int LosingPlayerId { get; set; }


        public PlayerDeathEvent(MatchPlayerData losingPlayerData, MatchPlayerData winningPlayerData) 
        { 
            //set winner and loser
        }
    }
}
