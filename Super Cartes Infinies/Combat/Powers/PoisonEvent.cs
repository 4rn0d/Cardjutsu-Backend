using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class PoisonEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }
    public int DamagedPlayableCardId { get; set; }
    public int OpposingPlayableId { get; set; }

    public PoisonEvent(MatchPlayerData playerData, MatchPlayerData opponentData, PlayableCard playableCard, PlayableCard opposingCard, int poisonValue = 0)
    {
        this.Events = new List<MatchEvent>();
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
                int damage = playableCard.GetPowerValue(Power.POISON_ID);
                this.Events.Add(new PoisonDamageEvent(opponentData, opposingCard, damage));
            }
        }
        else
        {
            this.Events.Add(new PoisonDamageEvent(opponentData, opposingCard, poisonValue));
            opposingCard.IncreaseStatusValue(Status.POISONED_ID, poisonValue);
        }
        this.DamagedPlayableCardId = opposingCard.Id;
    }
}