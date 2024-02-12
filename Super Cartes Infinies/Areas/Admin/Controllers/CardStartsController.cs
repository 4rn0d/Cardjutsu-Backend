using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CardStartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CardStartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/CardStarts
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CardStart.Include(c => c.Card).OrderBy(c => c.Card.Name).ToListAsync();
            return View(await applicationDbContext);
        }

        // GET: Admin/CardStarts/Create
        public IActionResult Create()
        {
            ViewData["CardId"] = new SelectList(_context.Cards, "Id", "Name");
            return View();
        }

        // POST: Admin/CardStarts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CardId")] CardStart cardStart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cardStart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CardId"] = new SelectList(_context.Cards, "Id", "Name", cardStart.CardId);
            return View(cardStart);
        }

        // GET: Admin/CardStarts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CardStart == null)
            {
                return NotFound();
            }

            var cardStart = await _context.CardStart
                .Include(c => c.Card)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cardStart == null)
            {
                return NotFound();
            }

            return View(cardStart);
        }

        // POST: Admin/CardStarts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CardStart == null)
            {
                return Problem("Entity set 'ApplicationDbContext.CardStart'  is null.");
            }
            var cardStart = await _context.CardStart.FindAsync(id);
            if (cardStart != null)
            {
                _context.CardStart.Remove(cardStart);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardStartExists(int id)
        {
          return (_context.CardStart?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
