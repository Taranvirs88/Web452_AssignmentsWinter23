﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Rulers.Data;
using Rulers.Models;

namespace Rulers.Controllers
{
    public class RulersController : Controller
    {
        private readonly RulersContext _context;

        public RulersController(RulersContext context)
        {
            _context = context;
        }

        // GET: Rulers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Ruler.ToListAsync());
        }

        // GET: Rulers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruler == null)
            {
                return NotFound();
            }

            return View(ruler);
        }

        // GET: Rulers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rulers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RulerTypes,Colour,RulerShape,Material,MeasurementSystem,Price,Rating")] Ruler ruler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ruler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ruler);
        }

        // GET: Rulers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler.FindAsync(id);
            if (ruler == null)
            {
                return NotFound();
            }
            return View(ruler);
        }

        // POST: Rulers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RulerTypes,Colour,RulerShape,Material,MeasurementSystem,Price,Rating")] Ruler ruler)
        {
            if (id != ruler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ruler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RulerExists(ruler.Id))
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
            return View(ruler);
        }

        // GET: Rulers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ruler = await _context.Ruler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ruler == null)
            {
                return NotFound();
            }

            return View(ruler);
        }

        // POST: Rulers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ruler = await _context.Ruler.FindAsync(id);
            _context.Ruler.Remove(ruler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RulerExists(int id)
        {
            return _context.Ruler.Any(e => e.Id == id);
        }
    }
}
