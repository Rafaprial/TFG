using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemasRafa.Data;
using CinemasRafa.Models;

namespace CinemasRafa.Controllers
{
    public class PegisController : Controller
    {
        private readonly ControlContext _context;

        public PegisController(ControlContext context)
        {
            _context = context;
        }

        // GET: Pegis
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pegi.ToListAsync());
        }

        // GET: Pegis/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pegi = await _context.Pegi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pegi == null)
            {
                return NotFound();
            }

            return View(pegi);
        }

        // GET: Pegis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pegis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EdadMin,PegiEdad")] Pegi pegi)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pegi);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pegi);
        }

        // GET: Pegis/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pegi = await _context.Pegi.FindAsync(id);
            if (pegi == null)
            {
                return NotFound();
            }
            return View(pegi);
        }

        // POST: Pegis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EdadMin,PegiEdad")] Pegi pegi)
        {
            if (id != pegi.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pegi);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PegiExists(pegi.Id))
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
            return View(pegi);
        }

/*        // GET: Pegis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pegi = await _context.Pegi
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pegi == null)
            {
                return NotFound();
            }

            return View(pegi);
        }

        // POST: Pegis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pegi = await _context.Pegi.FindAsync(id);
            _context.Pegi.Remove(pegi);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
*/
        private bool PegiExists(int id)
        {
            return _context.Pegi.Any(e => e.Id == id);
        }
    }
}
