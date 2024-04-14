using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Models.Dtos;
using System.Numerics;
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


        public async Task<List<Deck>> GetDecks(Player player)
        {
           
            List<Deck> decks = await _context.Decks.Where(d => d.PlayerId == player.Id).ToListAsync();
            return decks;
        }


        public async Task<bool> DeleteDeck(int id, Player player)
        {
            if (player.Decks.Where(x=>x.Id == id).Any())
            {
                Deck? deck = player.Decks.Where(p => p.Id == id).FirstOrDefault();
               
                    if (deck.IsCurrentDeck != true)
                    {
                        db.Decks.Remove(deck);
                        await db.SaveChangesAsync();
                        return true;
                    }
                    else
                    {
                        throw new Exception("Impossible de supprimer un deck courrant");
                    }
               
              
            }
            else
            {
                throw new Exception("Ce deck n'existe pas");
            }

           


        }
        public async Task<Deck> MakeCurrentDeck(int deckId, Player player)
        {
            
            List<Deck> decks = await _context.Decks.Where(p=>p.PlayerId == player.Id).ToListAsync();
            
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
        public async Task<Deck> PostDeck(DeckCardDTO deckDTO, Player player)
        {
          
            if (player.Decks.Where(x=>x.DeckName == deckDTO.Deck.DeckName).Any())
            {
                throw new Exception("Deux decks ne peuvent pas avoir le meme nom");
            }

            if (deckDTO.Deck.DeckName.IsNullOrEmpty())
            {
                throw new Exception("Nom du deck manquant");
            }

            if (deckDTO.cards.Count == 0)
            {
                throw new Exception("Cards manquant");
            }
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
                player.Decks.Add(deck);
                await db.SaveChangesAsync();

            return deck;



        }

        //Envoyer la valeur des config pour max deck et max card
        public Config ConfigurationDeck()
        {
           Config config = _context.Config.First();
            if (config == null)
            {
                return null;
            }
            return config;



        }
        
       public async Task<Deck> AjouterCarte(Player player, int id, Card card)
        {
            List<OwnedCard>? listOwnedCard = await _context.OwnedCards.Where(w => w.PlayerId == player.Id).ToListAsync();
            OwnedCard? ownedCard = listOwnedCard.FirstOrDefault(p => p.CardId == card.Id);
            if (ownedCard != null)
            {
                Deck? deck = player.Decks.Where(p => p.Id == id).FirstOrDefault();

                if (deck.OwnedCards.Where(p => p.CardId == card.Id).Any())
                {
                    throw new Exception("La carte existe dans le deck");
                }
                deck?.OwnedCards.Add(ownedCard);
                await db.SaveChangesAsync();
                return deck;
            }
            else
            {
                throw new Exception("Cette carte n'existe pas chez le player");
            }
            

        }

        public async Task<Deck> DeleteCardDuDeck(Player player, int id, Card card)
        {
            Deck deck = player.Decks.Where(p => p.Id == id).FirstOrDefault();

            if (deck == null)
            {
                throw new Exception("Deck is not found");
            }
            OwnedCard? cardDelete = deck.OwnedCards.Where(p => p.CardId == card.Id).FirstOrDefault();
            if (cardDelete == null)
            {
                throw new Exception("Le deck ne contient pas cette carte");
            }
            _context.Decks.Where(p => p.Id == deck.Id).FirstOrDefault().OwnedCards.Remove(cardDelete);
            await db.SaveChangesAsync();
            return deck;

        }
    }
}
