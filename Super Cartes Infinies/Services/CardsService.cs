using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;

namespace Super_Cartes_Infinies.Services
{
	public class CardsService : BaseService<Card>
    {
        private ApplicationDbContext _dbContext;

        public CardsService(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Card> GetPlayersCards()
        {
            // Stub: Pour l'intant, le stub retourne simplement les 8 premières cartes
            // L'implémentation réelle devra utiliser un service et retourner les cartes qu'un joueur possède
            // L'implémentation est la responsabilité de la personne en charge de la partie [Enregistrement et connexion]
            return _dbContext.Cards.Take(8).ToList();
        }
    }
}

