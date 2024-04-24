using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Super_Cartes_Infinies.Services.Interfaces;

namespace Super_Cartes_Infinies.Models
{
	public class Player : IModel
	{
		public Player()
		{
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string IdentityUserId { get; set; }
		public int EloScore { get; set; }
		[JsonIgnore]
		public virtual IdentityUser IdentityUser { get; set; }
		public virtual List<Card> OwnedCards { get; set;}
		[ValidateNever]
		[JsonIgnore]
		public virtual List<Deck> Decks { get; set; }
	}
}

