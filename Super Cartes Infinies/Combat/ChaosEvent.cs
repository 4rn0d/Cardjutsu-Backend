using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class ChaosEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }
    public ChaosEvent(MatchPlayerData playerData, PlayableCard playableCard)
    {
        this.PlayerId = playerData.PlayerId;
        this.PlayableCardId = playableCard.Id;
        (playableCard.Attack, playableCard.Health) = (playableCard.Health, playableCard.Attack);
        if (playableCard.Health <= 0)
        {
            playableCard.Health = 0;
            playerData.BattleField.Remove(playableCard);
            playerData.Graveyard.Add(playableCard);
        }
    }
}