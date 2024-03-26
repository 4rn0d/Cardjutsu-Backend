using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Migrations;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;

namespace Super_Cartes_Infinies.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DecksController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DecksController(ApplicationDbContext context)
        {
            _context = context;
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

        // GET: api/Decks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Deck>> GetDeck(int id)
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

            return deck;
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
          if (_context.Decks == null)
          {
              return Problem("Entity set 'ApplicationDbContext.Decks'  is null.");
            }

            try
            {
                Deck deck = new Deck();
                deck.DeckName = deckDTO.Deck.DeckName;
                deck.IsCurrentDeck = deckDTO.Deck.IsCurrentDeck;
                int nb = 0;
                foreach (Card card in deckDTO.cards)
                {
                    DeckCard deckCard = new DeckCard { Deck = deck, DeckId = deck.DeckId, CardId = card.Id, DeckCardId=nb };
                    nb++;
                    _context.Add(deckCard);
                }

             
                _context.Decks.Add(deck);
                await _context.SaveChangesAsync();

                return NoContent();
            }
            catch (Exception e)
            {
                return null;
            }


        }

        [HttpPost]
        public async Task<ActionResult<Deck>>MakeCurrentDeck(Deck deck)
        {
            if (_context.Decks == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Decks'  is null.");
            }

           
           
            if (deck != null) {
                deck.IsCurrentDeck = true;
                _context.Decks.Update(deck);
                _context.SaveChanges();
            }

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
