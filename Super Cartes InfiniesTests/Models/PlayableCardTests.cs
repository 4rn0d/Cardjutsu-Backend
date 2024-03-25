using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Cartes_Infinies.Models.Tests
{
    [TestClass()]
    public class PlayableCardTests
    {

        //DbContextOptions<ApplicationDbContext> options;

        [TestMethod()]
        public void HasPowerOtherTest()
        {
            //Assert.Fail();

            //using ApplicationDbContext db = new ApplicationDbContext(options);

            Card card = new Card();

            CardPower cardp = new CardPower();

            Power power = new Power();

            power.PowerId = 1;

            cardp.Power = power;

            card.CardPowers = new List<CardPower>();

            card.CardPowers.Add(cardp);

            PlayableCard playableCard = new PlayableCard(card);

            Assert.IsFalse(playableCard.HasPower(333));
            


        }

        [TestMethod()]
        public void HasPowerSameTest()
        {
            //Assert.Fail();

            //using ApplicationDbContext db = new ApplicationDbContext(options);

            Card card = new Card();

            CardPower cardp = new CardPower();

            Power power = new Power();

            power.PowerId = 1;

            cardp.Power = power;

            card.CardPowers = new List<CardPower>();

            card.CardPowers.Add(cardp);

            PlayableCard playableCard = new PlayableCard(card);

            Assert.IsTrue(playableCard.HasPower(Power.FIRST_STRIKE_ID));

        }
    }
}