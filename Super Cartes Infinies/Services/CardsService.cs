using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Combat;
using Super_Cartes_Infinies.Controllers;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using System.Security.Claims;

namespace Super_Cartes_Infinies.Services
{
	public class CardsService : BaseService<Card>
    {
        private ApplicationDbContext _dbContext;
        readonly ApplicationDbContext _context;
        private AccountController _AccountController;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CardsService(ApplicationDbContext dbContext, ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(dbContext)
        {
            _dbContext = dbContext;
            _context = context;
            _httpContextAccessor = httpContextAccessor;

        }

        public IEnumerable<Card> GetPlayersCards()
        {
            // Stub: Pour l'intant, le stub retourne simplement les 8 premières cartes
            // L'implémentation réelle devra utiliser un service et retourner les cartes qu'un joueur possède
            // L'implémentation est la responsabilité de la personne en charge de la partie [Enregistrement et connexion]
     
         
            string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //id Identityuser
            IdentityUser user = _context.Users.Find(userId);
            //trouver player avec id du usar avec IdentityUserDI
            Player player = _context.Players.SingleOrDefault(p => p.IdentityUserId == user.Id);
            //trouver tt les cards

          List<OwnedCard> ListownedCards = _context.OwnedCards.Where(p => p.PlayerId == player.Id).ToList();
            List<Card> cards = new List<Card>();

            if (ListownedCards.Count > 0)
            {
                
                foreach (OwnedCard ownedCard in ListownedCards)
                {
                    //ajouter les carte trouver a cards
                    cards.Add(_context.Cards.Where(c => c.Id == ownedCard.CardId).FirstOrDefault());
                }
                
                return cards;
            }
            return cards;

            

           
        }
    }
}

