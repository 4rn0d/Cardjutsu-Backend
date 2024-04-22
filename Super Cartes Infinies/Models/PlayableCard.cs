using System;
using System.ComponentModel.DataAnnotations;
using Super_Cartes_Infinies.Services.Interfaces;

namespace Super_Cartes_Infinies.Models
{
	public class PlayableCard : IModel
	{
		public PlayableCard()
		{
		}

		public PlayableCard(Card c)
		{
			Card = c;
			Health = c.Health;
			Attack = c.Attack;
			
			
		}

		public int Id { get; set; }
		public virtual Card Card { get; set; }
		public int OrdreId { get; set; }
		public int Health { get; set; }
		public int Attack { get; set; }

		public bool HasPower(int powerId)
		{
			// Return true if the Card has that power

			if(Card.CardPowers != null && Card.CardPowers.Count > 0)
			{
                List<CardPower> powerList = new List<CardPower>(Card.CardPowers);

                foreach (CardPower power in powerList)
                {
                    if (power.Power.PowerId == powerId)
                    {
                        return true;
                    }
                }
            }

			

			return false;
		}
		public int GetPowerValue(int powerId)
		{
			// Return the value of that power for that card. 
			// Simply returns 0 if the card doesn't have the power.
			if (!HasPower(powerId))
			{
				return 0;
			}

			return Card.CardPowers.Where(p => p.Power.PowerId == powerId).First().Value;

        }
	}
}

