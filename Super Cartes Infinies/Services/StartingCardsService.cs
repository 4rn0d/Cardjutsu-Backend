using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Services
{
	public class StartingCardsService
    {
        private ApplicationDbContext _dbContext;

        public StartingCardsService(ApplicationDbContext context)
        {
            _dbContext = context;
        }

        public List<Card> GetStartingCards() {
            // Stub: Pour l'intant, le stub retourne simplement les 7 premières cartes
            // L'implémentation réelle devra retourner les cartes référées par les starting cards configuré par l'administarteur
            // L'implémentation est la responsabilité de la personne en charge de la partie [Administration MVC]
            //return _dbContext.Cards.Take(7).ToList();

            List<CardStart> cardstart = _dbContext.CardStart.ToList();

            List<Card> cards = new List<Card>();

            foreach (CardStart c in cardstart)
            {
                cards.Add(c.Card);
            }
            return cards;
        }
    }
}

