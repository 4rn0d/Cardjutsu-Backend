using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class BoostAttackEvent : MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }
    public int BoostAmount { get; set; }
    public BoostAttackEvent(MatchPlayerData playerData, PlayableCard playableCard, int boostAmount)
    {
        this.PlayerId = playerData.PlayerId;
        this.PlayableCardId = playableCard.Id;
        playableCard.Attack += boostAmount;
        this.BoostAmount = boostAmount;
    }
}