using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using System.Security.Claims;

namespace Super_Cartes_Infinies.Services
{
    public class DecksService : BaseService<Deck>
    {
       
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ApplicationDbContext _context;

        public DecksService(  ApplicationDbContext context, IHttpContextAccessor httpContextAccessor) : base(context)
        {

            _httpContextAccessor = httpContextAccessor;
            _context = context;
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
        public async Task<bool> DeleteDeck(int id)
        {
            Deck? deck = await db.Decks.Where(p=>p.Id==id).FirstOrDefaultAsync();
            if (deck != null)
            {
                if (deck.IsCurrentDeck != true)
                {
                   db.Decks.Remove(deck);
                    await db.SaveChangesAsync();
                    return true;
                }
            }
            return false;


        }
        public async Task<Deck> MakeCurrentDeck(int deckId)
        {
            //string userId = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            //IdentityUser user = _context.Users.Find(userId);
            //Player player = await _context.Players.FirstOrDefaultAsync(p => p.IdentityUserId == user.Id);
            List<Deck> decks = await this.GetDecks();

            Deck? deckCurrent =  decks.Where(p => p.IsCurrentDeck == true).FirstOrDefault();
            Deck? existingDeck =  decks.Where(p=>p.Id==deckId).FirstOrDefault();
            if (deckCurrent != null)
            {
                deckCurrent.IsCurrentDeck = false;
             
            }

            if (existingDeck != null)
            {
                existingDeck.IsCurrentDeck = true;
               

            }

            await db.SaveChangesAsync();
            return existingDeck;
            

        }
        public async Task<Deck> PostDeck(DeckCardDTO deckDTO)
        {
            string userId =  _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
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
            await db.SaveChangesAsync();

            return deck;



        }
    }
}
