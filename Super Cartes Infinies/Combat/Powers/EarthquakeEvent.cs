using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class EarthquakeEvent : MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }

    public EarthquakeEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, PlayableCard playableCard)
    {
        this.Events = new List<MatchEvent> { };

        this.PlayerId = currentPlayerData.PlayerId;
        this.PlayableCardId = playableCard.Id;

        for (int i = 0; i < currentPlayerData.BattleField.Count; i++)
        {
            currentPlayerData.BattleField[i].Health -= playableCard.GetPowerValue(Power.EARTHQUAKE_ID);
            if (currentPlayerData.BattleField[i].Health <= 0)
            {
                currentPlayerData.Graveyard.Add(currentPlayerData.BattleField[i]);
                currentPlayerData.BattleField.RemoveAt(i);
            }
        }

        for (int i = 0; i < opposingPlayerData.BattleField.Count; i++)
        {
            opposingPlayerData.BattleField[i].Health -= playableCard.GetPowerValue(Power.EARTHQUAKE_ID);
            if (opposingPlayerData.BattleField[i].Health <= 0)
            {
                opposingPlayerData.Graveyard.Add(opposingPlayerData.BattleField[i]);
                opposingPlayerData.BattleField.RemoveAt(i);
            }
        }

        currentPlayerData.BattleField.Remove(playableCard);
        currentPlayerData.Graveyard.Add(playableCard);
    }
}