using Microsoft.Extensions.Logging;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat
{
    public class EndMatchEvent : MatchEvent
    {
        public int WinningPlayerId { get; set; }

        public EndMatchEvent(Match match, MatchPlayerData winningPlayerData, MatchPlayerData losingPlayerData)
        {
            // Pour l'instant, on n'arrête pas la simulation sur le serveur lorsqu'on atteint la fin de la partie.
            // Pour éviter qu'un joueur qui a gagné, mais qui meurt dans le même tour ne donne la victoire à l'autre, on vérifie si le match est déjà terminé!
            if (match.IsMatchCompleted)
                return;

            WinningPlayerId = winningPlayerData.PlayerId;

            match.IsMatchCompleted = true;


            string userId;
            if (match.PlayerDataA.PlayerId == winningPlayerData.PlayerId)
            {
                userId = match.UserAId;
                int eloScoreA = match.PlayerDataA.Player.EloScore;
                int eloScoreB = match.PlayerDataB.Player.EloScore;
                EloCalculator.CalculateELO(ref eloScoreA, ref eloScoreB, EloCalculator.GameOutcome.Win);
                match.PlayerDataA.Player.EloScore = eloScoreA;
                match.PlayerDataB.Player.EloScore = eloScoreB;
            }
            else
            {
                userId = match.UserBId;
                int eloScoreA = match.PlayerDataA.Player.EloScore;
                int eloScoreB = match.PlayerDataB.Player.EloScore;
                EloCalculator.CalculateELO(ref eloScoreA, ref eloScoreB, EloCalculator.GameOutcome.Loss);
                match.PlayerDataA.Player.EloScore = eloScoreA;
                match.PlayerDataB.Player.EloScore = eloScoreB;
            }


            match.WinnerUserId = userId;
        }
    }
}
