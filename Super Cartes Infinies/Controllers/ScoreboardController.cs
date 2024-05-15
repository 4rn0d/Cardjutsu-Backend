using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;
using Super_Cartes_Infinies.ViewModels;

namespace Super_Cartes_Infinies.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ScoreboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScoreboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: best 8 Players
        [HttpGet]
        public async Task<ActionResult<List<Player>>> GetBestPlayersScore()
        {
            var applicationDbContext = _context.Players.OrderByDescending(p => p.EloScore).Take(8);
            return await applicationDbContext.ToListAsync();
        }

        // GET: similar 8 Players
        [HttpGet("{username}")]
        public async Task<ActionResult<List<PositionPlayerVM>>> GetSimilarPlayersScore(string username)
        {

            Player currentP = _context.Players.Single(p => p.Name == username);

            //TODO

            List<PositionPlayerVM> list = new List<PositionPlayerVM>();

            var leaderboard = await _context.Players.OrderByDescending(p => p.EloScore).ToListAsync();

            var best5Players = await _context.Players.OrderByDescending(p => p.EloScore).Take(5).ToListAsync();
            var worst5Players = await _context.Players.OrderBy(p => p.EloScore).Take(5).ToListAsync();


            List<PositionPlayerVM> customlist = new List<PositionPlayerVM>();

            foreach (var player in leaderboard)
            {
                list.Add(new PositionPlayerVM
                {
                    Position = (leaderboard.IndexOf(player)+1),
                    Username = player.Name,
                    ELO = player.EloScore
                });
            }



            if (best5Players.Contains(currentP))
            {
                customlist = list.Take(8).ToList();
                return customlist;
            }

            if(worst5Players.Contains(currentP))
            {

                customlist = list.TakeLast(8).ToList();
                return customlist;
            }

            int indexOfCurrent = (leaderboard.IndexOf(currentP)+1);


            for(int i = (indexOfCurrent-4); i < (indexOfCurrent+4); i++)
            {
                customlist.Add(list.ElementAt(i));
            }




            return customlist;

        }

        
    }
}
