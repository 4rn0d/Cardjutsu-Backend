using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat;

public class RandomPainEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }

    public RandomPainEvent(MatchPlayerData currentPlayerData, PlayableCard randomPlayableCard, PlayableCard playableSpellCard)
    {
        Match match = new Match();
        match.RandomNumberService = new RandomNumberService();

        this.PlayerId = currentPlayerData.PlayerId;
        this.PlayableCardId = randomPlayableCard.Id;

        int randomPain = match.RandomNumberService.GetRandomNumber(6, 0);

        randomPlayableCard.Health -= randomPain;

        currentPlayerData.BattleField.Remove(playableSpellCard);
        currentPlayerData.Graveyard.Add(playableSpellCard);
    }
}