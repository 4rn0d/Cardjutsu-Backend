using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using System.Security.Claims;

namespace Super_Cartes_Infinies.Services
{
    public class DecksService
    {
        private readonly PlayersService _servicePlayer;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationDbContext _context;


        public DecksService(PlayersService playersService, IHttpContextAccessor httpContextAccessor, ApplicationDbContext applicationDbContext)
        {

            _servicePlayer = playersService;
            _httpContextAccessor = httpContextAccessor;
            _context = applicationDbContext;
        }


        public async Task<List<Deck>> GetDecks()
        {
            //string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //IdentityUser? user = _context.Users.Find(Id);
            //if (_context.Decks == null)
            //{
            //    return NotFound();
            //}

            //Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
            string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser user = _context.Users.Find(userId);
            Player player = _context.Players.SingleOrDefault(p => p.IdentityUserId == user.Id);

            List<Deck> decks = await _context.Decks.Where(d => d.PlayerId == player.Id).ToListAsync();
            return decks;
        }
    }
}
