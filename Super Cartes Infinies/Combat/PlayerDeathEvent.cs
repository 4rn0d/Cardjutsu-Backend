using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayerDeathEvent : MatchEvent
    {

        public int WinningPlayerId { get; set; }

        public int LosingPlayerId { get; set; }


        public PlayerDeathEvent(Match match,MatchPlayerData losingPlayerData, MatchPlayerData winningPlayerData) 
        { 
            //set winner and loser
            match.IsMatchCompleted = true;
            WinningPlayerId = winningPlayerData.PlayerId;
            LosingPlayerId = losingPlayerData.PlayerId;

            if(winningPlayerData == match.PlayerDataA)
            {
                match.WinnerUserId = match.UserAId;
            }
            else
            {
                match.WinnerUserId = match.UserBId;
            }
        }
    }
}
