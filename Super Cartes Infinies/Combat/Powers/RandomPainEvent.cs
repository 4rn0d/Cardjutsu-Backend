using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat;

public class RandomPainEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int OpponentId { get; set; }
    public int PlayableCardId { get; set; }
    public int RandomPain { get; set; }

    public RandomPainEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, PlayableCard randomPlayableCard, PlayableCard playableSpellCard)
    {
        Events = new List<MatchEvent> { };
        Match match = new Match();
        match.RandomNumberService = new RandomNumberService();

        PlayerId = currentPlayerData.PlayerId;
        OpponentId = opposingPlayerData.PlayerId;
        PlayableCardId = randomPlayableCard.Id;

        RandomPain = match.RandomNumberService.GetRandomNumber(6, 0);

        randomPlayableCard.Health -= RandomPain;
        if (randomPlayableCard.Health <= 0)
        {
            this.Events.Add(new CardDeathEvent(opposingPlayerData, randomPlayableCard));
        }

        currentPlayerData.BattleField.Remove(playableSpellCard);
        currentPlayerData.Graveyard.Add(playableSpellCard);
    }
}