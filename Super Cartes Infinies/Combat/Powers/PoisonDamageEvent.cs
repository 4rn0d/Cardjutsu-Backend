using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class PoisonDamageEvent:MatchEvent
{
    public int PlayerId { get; set; }
    public int DamagedPlayableCardId { get; set; }
    public int Damage { get; set; }

    public PoisonDamageEvent(MatchPlayerData playerData, PlayableCard opposingCard, int damage)
    {
        this.Events = new List<MatchEvent>();
        this.PlayerId = playerData.PlayerId;
        this.Damage = damage;

        opposingCard.Health -= damage;

        if (opposingCard.Health <= 0)
        {
            this.Events.Add(new CardDeathEvent(playerData, opposingCard));
        }

        this.DamagedPlayableCardId = opposingCard.Id;
    }
}