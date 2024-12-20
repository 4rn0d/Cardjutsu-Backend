﻿using System.Text.Json.Serialization;
using Super_Cartes_Infinies.Services.Interfaces;

namespace Super_Cartes_Infinies.Models
{
	public class MatchPlayerData : IModel
    {
		private const int STARTING_HEALTH = 20;

        public MatchPlayerData()
        {
        }

        // Utilisé par les tests
        public MatchPlayerData(int playerId)
		{
            PlayerId = playerId;
            Health = STARTING_HEALTH;
            CardsPile = new List<PlayableCard>();
            Hand = new List<PlayableCard>();
            BattleField = new List<PlayableCard>();
            Graveyard = new List<PlayableCard>();
        }

        public MatchPlayerData(Player p, IEnumerable<Card> cardList) : this(p.Id)
        {
            // TODO: Lors de l'intégration, remplacer par les cartes du joueur, on n'aura plus besoin de la liste de cartes
            Deck deckCurrent = p.Decks.Where(d => d.IsCurrentDeck == true).First();
            List<OwnedCard> ownedCards = deckCurrent.OwnedCards.ToList();
            List<Card> cards = new List<Card>();
            foreach (OwnedCard owned in ownedCards)
            {
                cards.Add(owned.Card);
            }
            foreach (var card in cards) {
                CardsPile.Add(new PlayableCard(card));
            }
        }

        public int Id { get; set; }
		public int Health { get; set; }
        public int Mana { get; set; }

        public virtual Player Player { get; set; }
        public int PlayerId { get; set; }

        // TODO: Il faut ordonner correctement toutes ces listes/stacks qui pourraient avoir un ordre différent quand on les obtient de la BD (mettre des indexes partout...)
        
        public List<PlayableCard> GetOrderedBattleField()
        {
            // Retourner les cartes dans l'ordre de l'Index
            return BattleField.OrderBy(x => x.OrdreId).ToList();
        }
        public void AddCardToBattleField(PlayableCard playableCard)
        {
            // Ajouter la carte au BattleField et lui donner le bon index (En fonction du nombre de cartes déjà sur le BattleField)
            int nbdeCarte = BattleField.Count;
            playableCard.OrdreId = nbdeCarte+1;
            //Save the modif ?

        }
        public void RemoveCardFromBattleField(PlayableCard playableCard)
        {
            // Retirer la carte du BattleField
            BattleField.Remove(playableCard);
            // Atention: Il faut mettre les autres cartes du BattleField à jour!
            foreach (var card in BattleField)
            {
                if (playableCard.OrdreId < card.OrdreId)
                {
                    card.OrdreId--;
                }
            }
            //Save the modif
        }
        //[JsonIgnore]
        public virtual List<PlayableCard> CardsPile { get; set; }
        public virtual List<PlayableCard> Hand { get; set; }

        public virtual List<PlayableCard> BattleField { get; set; }
        public virtual List<PlayableCard> Graveyard { get; set; }
    }
}

