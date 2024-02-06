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
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public String Password { get; set; } = null!;
        public required string IdentityUserId { get; set; }
		[JsonIgnore]
		public virtual IdentityUser IdentityUser { get; set; }
    }
}

