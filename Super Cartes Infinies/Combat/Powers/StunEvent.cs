using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class StunEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }
    public int StunnedPlayableCardId { get; set; }
    public int OpposingPlayableId { get; set; }

    public StunEvent(MatchPlayerData playerData, PlayableCard playableCard, PlayableCard opposingCard)
    {
        this.PlayerId = playerData.PlayerId;
        this.PlayableCardId = playableCard.Id;
        this.OpposingPlayableId = opposingCard.Id;

        Status stunStatus = new Status();
        stunStatus.Id = Status.STUNNED_ID;

        if (!opposingCard.HasStatus(Status.STUNNED_ID))
        {
            opposingCard.CardStatuses.Add(new PlayableCardStatus()
            {
                Status = stunStatus,
                Value = playableCard.GetPowerValue(Power.STUN_ID)
            });
        }
        else
        {
            opposingCard.DecreaseStatusValue(Status.STUNNED_ID, 1);
        }
        this.StunnedPlayableCardId = opposingCard.Id;
    }
}