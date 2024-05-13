using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Combat
{
    public class PlayCardEvent : MatchEvent
    {

        public int PlayableCardId { get; set; }
        public int PlayerId { get; set; }
        public int Mana {get; set;}
         public PlayCardEvent(MatchPlayerData currentPlayerData, MatchPlayerData opposingPlayerData, int playableCardId)
        {
            this.Events = new List<MatchEvent> { };
            Match match = new Match();
            match.RandomNumberService = new RandomNumberService();

            PlayableCard playedcard = currentPlayerData.Hand.Where(c => c.Id == playableCardId).FirstOrDefault()!;

            if (currentPlayerData.Mana - playedcard.Card.Cost >= 0)
            {
                currentPlayerData.BattleField.Add(playedcard);
                currentPlayerData.Hand.Remove(playedcard);
                currentPlayerData.Mana -= playedcard.Card.Cost;
                PlayerId = currentPlayerData.PlayerId;
                PlayableCardId = playedcard.Id;
                Mana = currentPlayerData.Mana;

                if (playedcard.Card.IsSpell)
                {
                    if (playedcard.HasPower(Power.LIGHTNING_STRIKE_ID))
                    {
                        this.Events.Add(new LightningStrikeEvent(currentPlayerData, opposingPlayerData, playedcard));
                    }

                    if (playedcard.HasPower(Power.EARTHQUAKE_ID))
                    {
                        this.Events.Add(new EarthquakeEvent(currentPlayerData, opposingPlayerData, playedcard));
                    }

                    if (playedcard.HasPower(Power.RANDOM_PAIN_ID))
                    {
                        PlayableCard randomCard = opposingPlayerData.BattleField[match.RandomNumberService.GetRandomNumber(opposingPlayerData.BattleField.Count, 0)];
                        this.Events.Add(new RandomPainEvent(currentPlayerData, randomCard, playedcard));
                    }
                }
            }
            else
            {
                throw new Exception("Le joueur n'a pas assez de mana pour jouer la carte");
            }

        }
    }
}
