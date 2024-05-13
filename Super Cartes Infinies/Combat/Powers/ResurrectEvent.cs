using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Combat;

public class ResurrectEvent: MatchEvent
{
    public int PlayerId { get; set; }
    public int PlayableCardId { get; set; }
    public int ResurrectedCardId { get; set; }
    public ResurrectEvent(MatchPlayerData playerData, PlayableCard playableCard, Match match)
    {
        this.PlayerId = playerData.PlayerId;
        this.PlayableCardId = playableCard.Id;
        int cardsInGraveyard = playerData.Graveyard.Count;
        int random = match.RandomNumberService.GetRandomNumber(cardsInGraveyard, 0);
        PlayableCard resurrectedCard = playerData.Graveyard[random];
        playerData.Graveyard.Remove(resurrectedCard);
        resurrectedCard.Health = 1;
        playerData.BattleField.Add(resurrectedCard);
        ResurrectedCardId = resurrectedCard.Id;
    }
}