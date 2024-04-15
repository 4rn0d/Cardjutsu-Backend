using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ConfigsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ConfigsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Configs
        public async Task<IActionResult> Index()
        {
              return _context.Config != null ? 
                          View(await _context.Config.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Config'  is null.");
        }

        // GET: Admin/Configs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Config == null)
            {
                return NotFound();
            }

            var config = await _context.Config
                .FirstOrDefaultAsync(m => m.Id == id);
            if (config == null)
            {
                return NotFound();
            }

            return View(config);
        }

        // GET: Admin/Configs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Configs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NbCardsStart,ManaPerRound,NbDecks,NbCarteParDeck")] Config config)
        {
            if (ModelState.IsValid)
            {
                _context.Add(config);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(config);
        }

        // GET: Admin/Configs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Config == null)
            {
                return NotFound();
            }

            var config = await _context.Config.FindAsync(id);
            if (config == null)
            {
                return NotFound();
            }
            return View(config);
        }

        // POST: Admin/Configs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NbCardsStart,ManaPerRound,NbDecks,NbCarteParDeck")] Config config)
        {
            if (id != config.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(config);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfigExists(config.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(config);
        }

        // GET: Admin/Configs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Config == null)
            {
                return NotFound();
            }

            var config = await _context.Config
                .FirstOrDefaultAsync(m => m.Id == id);
            if (config == null)
            {
                return NotFound();
            }

            return View(config);
        }

        // POST: Admin/Configs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Config == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Config'  is null.");
            }
            var config = await _context.Config.FindAsync(id);
            if (config != null)
            {
                _context.Config.Remove(config);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfigExists(int id)
        {
          return (_context.Config?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
