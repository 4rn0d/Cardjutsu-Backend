﻿using Microsoft.AspNetCore.Mvc;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.Services;

namespace Super_Cartes_Infinies.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CardController : ControllerBase
    {
        private ApplicationDbContext _dbContext;
        private CardsService _cardsService;

        public CardController(ApplicationDbContext dbContext, CardsService cardsService)
        {
            _dbContext = dbContext;
            _cardsService = cardsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Card>> GetAllCards()
        {
            return Ok(_cardsService.GetAll());
        }

        // TODO: La version réelle devra utiliser [Authorize] pour protéger les données est s'assurer d'avoir accès au User
        [HttpGet]
        public ActionResult<IEnumerable<Card>> GetPlayersCards()
        {
            return Ok(_cardsService.GetPlayersCards());
        }

        [HttpGet("{id}")]
        public ActionResult<Card> GetCardPowers(int id)
        {
            return Ok(_cardsService.GetCardPowers(id));
        }
      
    }
}
