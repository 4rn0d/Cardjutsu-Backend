using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Controllers
{
    public class ScoreboardController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ScoreboardController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: best 8 Players
        public async Task<IActionResult> GetBestPlayersScore()
        {
            var applicationDbContext = _context.Players.OrderByDescending(p => p.EloScore).Take(8);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: similar 8 Players
        public async Task<IActionResult> GetSimilarPlayersScore(int id)
        {

            Player currentP = _context.Players.Single(p => p.Id == id);

            //TODO

            var applicationDbContext = _context.Players.OrderByDescending(p => p.EloScore).Take(8);

            if(applicationDbContext.Contains(currentP)) 
            {
                return View(await applicationDbContext.ToListAsync());
            }
            return View(await applicationDbContext.ToListAsync());
        }

        
    }
}
