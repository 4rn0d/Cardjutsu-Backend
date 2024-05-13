using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class EarthquakeEvent : MatchEvent
{
    public int PlayerId { get; set; }
    public int OpponentId { get; set; }
    public int PlayableCardId { get; set; }
    public int Damage { get; set; }

    public EarthquakeEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, PlayableCard playableCard)
    {
        this.Events = new List<MatchEvent> { };

        this.PlayerId = currentPlayerData.PlayerId;
        this.OpponentId = opposingPlayerData.PlayerId;
        this.PlayableCardId = playableCard.Id;
        this.Damage = playableCard.GetPowerValue(Power.EARTHQUAKE_ID);

        for (int i = 0; i < currentPlayerData.BattleField.Count; i++)
        {
            currentPlayerData.BattleField[i].Health -= this.Damage;
            if (currentPlayerData.BattleField[i].Health <= 0)
            {
                this.Events.Add(new CardDeathEvent(currentPlayerData, currentPlayerData.BattleField[i]));
            }
        }

        for (int i = 0; i < opposingPlayerData.BattleField.Count; i++)
        {
            opposingPlayerData.BattleField[i].Health -= playableCard.GetPowerValue(Power.EARTHQUAKE_ID);
            if (opposingPlayerData.BattleField[i].Health <= 0)
            {
                this.Events.Add(new CardDeathEvent(opposingPlayerData, opposingPlayerData.BattleField[i]));
            }
        }

        currentPlayerData.BattleField.Remove(playableCard);
        currentPlayerData.Graveyard.Add(playableCard);
    }
}