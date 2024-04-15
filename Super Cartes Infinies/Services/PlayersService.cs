using Microsoft.AspNetCore.Identity;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Services
{
	public class PlayersService : BaseService<Player>
    {
        public readonly StartingCardsService _StartingCardsService;
        readonly ApplicationDbContext _context;

        public PlayersService(ApplicationDbContext context, StartingCardsService startingCardsService) : base(context)
        {
            _StartingCardsService = startingCardsService;
            _context = context;
        }

        public Player CreatePlayer(IdentityUser user)
        {


            Player player = new Player()
            {
                Id = 0,
                IdentityUserId = user.Id,
                IdentityUser = user,
                Name = user.Email!,
                 Decks = new List<Deck>()

            };
            player = Add(player);
            


            // TODO: Utilisez le service StartingCardsService pour obtenir les cartes de départ
            List<Card> cards = new List<Card>();
            List<OwnedCard> ownedCards = new List<OwnedCard>();
            cards = _StartingCardsService.GetStartingCards();
            foreach (Card card in cards) {
                OwnedCard ownedCard = new OwnedCard()
                {
                    Id = 0,
                    PlayerId = player.Id,
                    CardId =card.Id,
                    

                };
                if (!ownedCards.Any(oc => oc.CardId == card.Id))
                {
                    ownedCards.Add(ownedCard);
                    
                }
                _context.OwnedCards.Add(ownedCard);
                

            }

            //ajuster la liste des cards pour les standards
            Config config = _context.Config.First();
            ownedCards = ownedCards.Take(config.NbCardsStart).ToList();

            //Deck
            Deck deck = new Deck()
            {
                DeckName = "Depart",
                IsCurrentDeck = true,
                PlayerId = player.Id,
                OwnedCards = ownedCards


            };
            try
            {
                _context.Decks.Add(deck);
                player.Decks.Add(deck);
                
                _context.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
          

            // TODO: Ajoutez ces cartes au joueur en utilisant le modèle OwnedCard que vous allez devoir ajouter



            return player;
        }

        public virtual Player GetPlayerFromUserId(string userId)
        {
            return db.Players.Single(p => p.IdentityUserId == userId);
        }

        public Player GetPlayerFromUserName(string userName)
        {
            return db.Players.Single(p => p.IdentityUser!.UserName == userName);
        }
    }
}

