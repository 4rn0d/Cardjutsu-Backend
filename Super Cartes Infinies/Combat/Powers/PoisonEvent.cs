using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class PoisonEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }
    public int DamagedPlayableCardId { get; set; }
    public int OpposingPlayableId { get; set; }

    public PoisonEvent(MatchPlayerData playerData, PlayableCard playableCard, PlayableCard opposingCard)
    {
        this.PlayerId = playerData.PlayerId;
        this.PlayableCardId = playableCard.Id;
        this.OpposingPlayableId = opposingCard.Id;

        Status poisonStatus = new Status();
        poisonStatus.Id = Status.POISONED_ID;

        if (!opposingCard.HasStatus(Status.POISONED_ID))
        {
            opposingCard.CardStatuses.Add(new PlayableCardStatus()
            {
                Status = poisonStatus,
                Value = playableCard.GetPowerValue(Power.POISON_ID)
            });

            if (opposingCard.CardStatuses.Count != 0)
            {
                opposingCard.Health -= playableCard.GetPowerValue(Power.POISON_ID);
            }
        }
        else
        {
            opposingCard.IncreaseStatusValue(Status.POISONED_ID, playableCard.GetPowerValue(Power.POISON_ID));
        }
        this.DamagedPlayableCardId = opposingCard.Id;
    }
}