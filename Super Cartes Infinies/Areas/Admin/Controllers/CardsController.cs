﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;
using Super_Cartes_Infinies.Data;
using Super_Cartes_Infinies.Models;

namespace Super_Cartes_Infinies.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class CardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/Cards
        public async Task<IActionResult> Index()
        {
              return _context.Cards != null ? 
                          View(await _context.Cards.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Cards'  is null.");
        }

       

        // GET: Admin/Cards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Cards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Attack,Health,Cost,Colour,ImageUrl")] Card card)
        {
            if (ModelState.IsValid)
            {
                _context.Add(card);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(card);
        }

        // GET: Admin/Cards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Cards == null)
            {
                return NotFound();
            }

            var card = await _context.Cards.FindAsync(id);
            if (card == null)
            {
                return NotFound();
            }
            ViewData["PowerList"] = new SelectList(_context.Power, "PowerId", "Name");
            CardPower cardPower = new CardPower();
            cardPower.Power = new Power();
            ViewData["CardPower"] = cardPower;
            ViewData["PowerId"] = 0;
            ViewData["Value"] = 0;
            return View(card);
        }

        // POST: Admin/Cards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Attack,Health,Cost,ImageUrl,Colour")] Card card)
        {
            if (id != card.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(card);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CardExists(card.Id))
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
            return View(card);
        }

        // GET: Admin/Cards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Cards == null)
            {
                return NotFound();
            }

            var card = await _context.Cards
                .FirstOrDefaultAsync(m => m.Id == id);
            if (card == null)
            {
                return NotFound();
            }

            return View(card);
        }

        // POST: Admin/Cards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Cards == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Cards'  is null.");
            }
            var card = await _context.Cards.FindAsync(id);
            if (card != null)
            {
                _context.Cards.Remove(card);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CardExists(int id)
        {
          return (_context.Cards?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        public async Task<IActionResult> RemovePowers(int cardId, int cardPowerId)
        {
            Card card;
            card = _context.Cards.Where(c => c.Id == cardId).First();

            card.CardPowers.RemoveAt(cardPowerId);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Edit), card);
        }

        [HttpPost]
        public async Task<IActionResult> AddPower(int cardId, int powerId, int value)
        {
            Card card;
            card = _context.Cards.Where(c => c.Id == cardId).First();
            if (card.CardPowers == null)
            {
                card.CardPowers = new List<CardPower>();
            }

            int score = 0;
            for (int i = 0; i < card.CardPowers.Count; i++)
            {
                if (card.CardPowers[i].Power.PowerId != powerId)
                {
                    score++;
                }
            }

            if (score == card.CardPowers.Count)
            {
                CardPower cardPower = new CardPower();
                cardPower.Power = _context.Power.Where(p => p.PowerId == powerId).First();
                cardPower.Value = value;
                cardPower.Card = card;

                card.CardPowers.Add(cardPower);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Edit), card);
        }
    }
}
