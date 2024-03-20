using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Super_Cartes_Infinies.Services.Interfaces;

namespace Super_Cartes_Infinies.Models
{
    public class Card:IModel
	{
		public Card() { }

		public int Id { get; set; }
		public string Name { get; set; } = "";
		public int Attack { get; set; }
		public int Health { get; set; }
		[DisplayName("Mana cost")]
        public int Cost { get; set; }
        public string Colour { get; set; }
        public string ImageUrl { get; set; } = "";

        [ValidateNever]
        public virtual List<CardPower> CardPowers { get; set; }

        public bool HasPower(int powerId)
        {
            return false;
            // Return true if the Card has that power
        }
        public int GetPowerValue(int powerId)
        {
            return 0;
            // Return the value of that power for that card. 
            // Simply returns 0 if the card doesn't have the power.
        }
    }
}

