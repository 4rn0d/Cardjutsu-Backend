﻿namespace Super_Cartes_Infinies.Models
{
    public class OwnedCard
    {
        public OwnedCard()
        {
        }

        public int Id { get; set; }
        public int PlayerID { get; set; }
        public virtual List<Card> ListCards { get; set; }
    }
}