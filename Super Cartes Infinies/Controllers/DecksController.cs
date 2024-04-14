using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        readonly ApplicationDbContext _context;
        private DecksService _decksService;

        public DecksController(ApplicationDbContext context, DecksService DecksService)
        {
            _context = context;
            _decksService = DecksService;
        }

      

        [HttpGet]
        public ActionResult<Config> GetConfigDecks()
        {
            if (_context.Config == null)
            {
                return NotFound();
            }

            Config config = _decksService.ConfigurationDeck();
            return config;
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
            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser? user = _context.Users.Find(Id);
            Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
            List<Deck> decks = await _decksService.GetDecks(player);

            if (decks == null)
            {
                return NotFound();
            }

            return decks;
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
                //Deck deck = new Deck();
                //deck.DeckName = deckDTO.Deck.DeckName;
                //deck.IsCurrentDeck = deckDTO.Deck.IsCurrentDeck;
                //deck.PlayerId = player.Id;
                //List<OwnedCard> ownedCards = new List<OwnedCard>(); 
                //foreach (Card card in deckDTO.cards)
                //{
                //    OwnedCard ownedCard = _context.OwnedCards.Where(p=>p.Card == card).FirstOrDefault();
                //    ownedCard.decks.Add(deck);
                //    ownedCards.Add(ownedCard);

                //}
                //deck.OwnedCards = ownedCards;



                //_context.Decks.Add(deck);
                //await _context.SaveChangesAsync();
                Deck re = await _decksService.PostDeck(deckDTO, player);
                //await _context.SaveChangesAsync();

                return Ok();
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


            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser? user = _context.Users.Find(Id);
            Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
            //Deck? deckCurrent =  _context.Decks.Where(p => p.IsCurrentDeck == true).FirstOrDefault();
            //if (deckCurrent != null)
            //{
            //    deckCurrent.IsCurrentDeck = false;
            //    await _context.SaveChangesAsync();
            //}




            //    var existingDeck = await _context.Decks.FindAsync(deckId);
            //    if (existingDeck == null)
            //    {
            //        return NotFound("Deck not found.");
            //    }

            //    existingDeck.IsCurrentDeck = true;
            //    await _context.SaveChangesAsync();
            Deck deck =await _decksService.MakeCurrentDeck(deckId, player);
            //await _context.SaveChangesAsync();
            return Ok();
         
        }

        // DELETE: api/Decks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeck(int id)
        {
            if (_context.Decks == null)
            {
                return NotFound();
            }
            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser? user = _context.Users.Find(Id);
            Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
            bool re =await _decksService.DeleteDeck(id, player); //je retourne un bool car je dois mettre un await ou sinon System.ObjectDisposedException.
            return Ok();
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> DeleteCardDuDeck(int id, Card card)
        {
         

            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser? user = _context.Users.Find(Id);
            Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
            Deck deck= await _decksService.DeleteCardDuDeck(player, id, card);
            // faire 4 test 
           
            return Ok();
        }

     

        [HttpPost("{id}")]
        public async Task<ActionResult<Deck>> AjouterCarte(int id, Card card)
        {
            string Id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            IdentityUser? user = _context.Users.Find(Id);
            Player player = await _context.Players.Where(p => p.IdentityUserId == user.Id).FirstAsync();
         

            try
            {
                
               Deck deck =await _decksService.AjouterCarte(player, id, card);
            

                return Ok();
            }
            catch (Exception e)
            {
                return Problem();
            }


        }
    }
}
