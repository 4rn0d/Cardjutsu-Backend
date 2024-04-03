using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
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
        public async void DeleteDeck(int id)
        {
            Deck? deck = await _context.Decks.FindAsync(id);
            if (deck != null)
            {
                if (deck.IsCurrentDeck != true)
                {
                    _context.Decks.Remove(deck);
                    await _context.SaveChangesAsync();

                }
            }


        }
        public async void MakeCurrentDeck(int deckId)
        {
            Deck? deckCurrent = _context.Decks.Where(p => p.IsCurrentDeck == true).FirstOrDefault();
            if (deckCurrent != null)
            {
                deckCurrent.IsCurrentDeck = false;
                await _context.SaveChangesAsync();
            }




            Deck existingDeck = await _context.Decks.FindAsync(deckId);
            if (existingDeck != null)
            {
                existingDeck.IsCurrentDeck = true;
                await _context.SaveChangesAsync();

            }


        }
        public async void PostDeck(DeckCardDTO deckDTO)
        {
            string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser user = _context.Users.Find(userId);
            Player player = _context.Players.SingleOrDefault(p => p.IdentityUserId == user.Id);


            
                Deck deck = new Deck();
                deck.DeckName = deckDTO.Deck.DeckName;
                deck.IsCurrentDeck = deckDTO.Deck.IsCurrentDeck;
                deck.PlayerId = player.Id;
                List<OwnedCard> ownedCards = new List<OwnedCard>();
                foreach (Card card in deckDTO.cards)
                {
                    OwnedCard ownedCard = _context.OwnedCards.Where(p => p.Card == card).FirstOrDefault();
                    ownedCard.decks.Add(deck);
                    ownedCards.Add(ownedCard);

                }
                deck.OwnedCards = ownedCards;



                _context.Decks.Add(deck);
                await _context.SaveChangesAsync();


                
           

        }
    }
}
