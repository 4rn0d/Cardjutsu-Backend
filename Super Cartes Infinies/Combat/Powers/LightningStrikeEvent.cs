using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class LightningStrikeEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }
    public int NewOpponentHealth { get; set; }
    public int OpponentId { get; set; }

    public LightningStrikeEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, PlayableCard playableCard)
    {

        this.PlayerId = currentPlayerData.PlayerId;
        this.PlayableCardId = playableCard.Id;
        this.OpponentId = opposingPlayerData.PlayerId;

        opposingPlayerData.Health -= playableCard.GetPowerValue(Power.LIGHTNING_STRIKE_ID);
        this.NewOpponentHealth = opposingPlayerData.Health;

        currentPlayerData.BattleField.Remove(playableCard);
        currentPlayerData.Graveyard.Add(playableCard);
    }
}