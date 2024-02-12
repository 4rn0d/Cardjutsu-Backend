using Microsoft.AspNetCore.Identity;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Services
{
	public class PlayersService : BaseService<Player>
    {
        public readonly StartingCardsService _StartingCardsService;
        public PlayersService(ApplicationDbContext context, StartingCardsService startingCardsService) : base(context)
        {
            _StartingCardsService = startingCardsService;
        }

        public Player CreatePlayer(IdentityUser user)
        {
            Player p = new Player()
            {
                Id = 0,
                IdentityUserId = user.Id,
                IdentityUser = user,
                Name = user.Email!
            };
            p = Add(p);
            //Player player = new Player()
            //{

            //    Name = user.UserName,
            //    IdentityUser = user

            //};

            // TODO: Utilisez le service StartingCardsService pour obtenir les cartes de départ
            OwnedCard ownedCard = new OwnedCard()
            {
                Id = 0,
                PlayerID = p.Id,
                ListCards = _StartingCardsService.GetStartingCards()

            };
          
            // TODO: Ajoutez ces cartes au joueur en utilisant le modèle OwnedCard que vous allez devoir ajouter

          

            return p;
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

