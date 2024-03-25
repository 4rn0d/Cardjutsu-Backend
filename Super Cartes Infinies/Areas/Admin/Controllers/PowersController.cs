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
    public class PowersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PowersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Powers
        public async Task<IActionResult> Index()
        {
              return _context.Power != null ? 
                          View(await _context.Power.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Power'  is null.");
        }

        // GET: Admin/Powers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Power == null)
            {
                return NotFound();
            }

            var power = await _context.Power
                .FirstOrDefaultAsync(m => m.PowerId == id);
            if (power == null)
            {
                return NotFound();
            }

            return View(power);
        }

        // GET: Admin/Powers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Powers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PowerId,Name,Description,Icone")] Power power)
        {
            if (ModelState.IsValid)
            {
                _context.Add(power);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(power);
        }

        // GET: Admin/Powers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Power == null)
            {
                return NotFound();
            }

            var power = await _context.Power.FindAsync(id);
            if (power == null)
            {
                return NotFound();
            }

            return View(power);
        }

        // POST: Admin/Powers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PowerId,Name,Description,Icone")] Power power)
        {
            if (id != power.PowerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(power);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PowerExists(power.PowerId))
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
            return View(power);
        }

        // GET: Admin/Powers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Power == null)
            {
                return NotFound();
            }

            var power = await _context.Power
                .FirstOrDefaultAsync(m => m.PowerId == id);
            if (power == null)
            {
                return NotFound();
            }

            return View(power);
        }

        // POST: Admin/Powers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Power == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Power'  is null.");
            }
            var power = await _context.Power.FindAsync(id);
            if (power != null)
            {
                _context.Power.Remove(power);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PowerExists(int id)
        {
          return (_context.Power?.Any(e => e.PowerId == id)).GetValueOrDefault();
        }
    }
}
