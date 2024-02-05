using Microsoft.AspNetCore.Identity;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Services
{
	public class PlayersService : BaseService<Player>
    {
        public PlayersService(
            ApplicationDbContext context
        ) : base(context)
        {
        }

        public Player CreatePlayer(IdentityUser user)
        {
            Player p = new Player()
            {
                Id = 0,
                IdentityUserId = user.Id,
                Name = user.Email!
            };

            // TODO: Utilisez le service StartingCardsService pour obtenir les cartes de départ
            // TODO: Ajoutez ces cartes au joueur en utilisant le modèle OwnedCard que vous allez devoir ajouter

            p = Add(p);

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

