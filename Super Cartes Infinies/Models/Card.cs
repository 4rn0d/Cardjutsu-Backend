﻿using System.ComponentModel;
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
        public string ImageUrl { get; set; } = "";
    }
}
