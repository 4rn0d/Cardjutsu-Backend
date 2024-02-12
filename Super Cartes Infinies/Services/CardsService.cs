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
            //string? Id = _AccountController.User.FindFirstValue(ClaimTypes.NameIdentifier);
         
            string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //id Identityuser
            IdentityUser user = _context.Users.Find(userId);
            //trouver player avec id du usar avec IdentityUserDI
            Player player = _context.Players.FirstOrDefault(p => p.IdentityUserId == user.Id);
            //trouver tt les cards
            OwnedCard ownedCard = _context.OwnedCards.FirstOrDefault(p => p.PlayerID == player.Id);
            if (ownedCard == null) { 
                return Enumerable.Empty<Card>();
            }
            return ownedCard.ListCards.ToList();
        }
    }
}

