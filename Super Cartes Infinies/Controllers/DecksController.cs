using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Migrations;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DecksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private DecksService _decksService;

        public DecksController(ApplicationDbContext context, DecksService DecksService)
        {
            _context = context;
            _decksService = DecksService;
        }

        // GET: api/Decks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Deck>>> GetDecks()
        {
          if (_context.Decks == null)
          {
              return NotFound();
          }
          List<Deck> decks = await _context.Decks.ToListAsync();
            return decks;
        }

       
        [HttpGet]
        public async Task<ActionResult<List<Deck>>> GetDeck()
        {
            //string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            //IdentityUser? user = _context.Users.Find(Id);
            //if (_context.Decks == null)
            //  {
            //  return NotFound();
            //  }

            //Player player = await _context.Players.Where(p=>p.IdentityUserId == user.Id).FirstAsync();

            List<Deck> decks = await _decksService.GetDecks();

            if (decks == null)
            {
                return NotFound();
            }

            return decks;
        }

        // PUT: api/Decks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeck(int id, Deck deck)
        {
            if (id != deck.DeckId)
            {
                return BadRequest();
            }

            _context.Entry(deck).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DeckExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Decks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Deck>> PostDeck(DeckCardDTO deckDTO)
        {
            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser? user = _context.Users.Find(Id);
            Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
            if (_context.Decks == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Decks'  is null.");
            }

            try
            {
                Deck deck = new Deck();
                deck.DeckName = deckDTO.Deck.DeckName;
                deck.IsCurrentDeck = deckDTO.Deck.IsCurrentDeck;
                deck.PlayerId = player.Id;
                List<OwnedCard> ownedCards = new List<OwnedCard>(); 
                foreach (Card card in deckDTO.cards)
                {
                    OwnedCard ownedCard = _context.OwnedCards.Where(p=>p.Card == card).FirstOrDefault();
                    ownedCard.decks.Add(deck);
                    ownedCards.Add(ownedCard);
                
                }
                deck.OwnedCards = ownedCards;
               

             
                _context.Decks.Add(deck);
                await _context.SaveChangesAsync();


                return NoContent();
            }
            catch (Exception e)
            {
                return Problem();
            }


        }

        [HttpGet("{deckId}")]
        public async Task<ActionResult<Deck>>MakeCurrentDeck(int deckId)
        {
            if (_context.Decks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Decks'  is null.");
            }

         

            Deck? deckCurrent =  _context.Decks.Where(p => p.IsCurrentDeck == true).FirstOrDefault();
            if (deckCurrent != null)
            {
                deckCurrent.IsCurrentDeck = false;
                await _context.SaveChangesAsync();
            }


         
           
                var existingDeck = await _context.Decks.FindAsync(deckId);
                if (existingDeck == null)
                {
                    return NotFound("Deck not found.");
                }

                existingDeck.IsCurrentDeck = true;
                await _context.SaveChangesAsync();
                return NoContent();
         
        }

        // DELETE: api/Decks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeck(int id)
        {
            if (_context.Decks == null)
            {
                return NotFound();
            }
            var deck = await _context.Decks.FindAsync(id);
            if (deck == null)
            {
                return NotFound();
            }
            if (deck.IsCurrentDeck == true)
            {
                return Problem();
            }
            _context.Decks.Remove(deck);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DeckExists(int id)
        {
            return (_context.Decks?.Any(e => e.DeckId == id)).GetValueOrDefault();
        }
    }
}
