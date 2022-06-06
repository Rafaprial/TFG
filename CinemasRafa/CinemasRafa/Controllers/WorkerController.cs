using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemasRafa.Data;
using CinemasRafa.Filters;
using CinemasRafa.Models;

namespace CinemasRafa.Controllers
{
    [ServiceFilter(typeof(AdminFilter))]
    //[ServiceFilter(typeof(RecepcionistFilter))]
    public class WorkerController : Controller
    {
        private readonly ControlContext _context;

        public WorkerController(ControlContext context)
        {
            _context = context;
        }

        // GET: Workers
        public async Task<IActionResult> Index()
        {
            var controlContext = _context.Worker.Include(t => t.CuentaUsuario);
            return View(await controlContext.ToListAsync());
        }

        // GET: Workers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Worker = await _context.Worker
                .Include(t => t.CuentaUsuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Worker == null)
            {
                return NotFound();
            }

            return View(Worker);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Worker = await _context.Worker.FindAsync(id);
            if (Worker == null)
            {
                return NotFound();
            }
            ViewData["CuentaUsuarioID"] = new SelectList(_context.CuentaUsuario, "ID", "Email", Worker.CuentaUsuarioID);
            return View(Worker);
        }

        // POST: Workers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Surname,Dni,Phone,CuentaUsuarioID")] Worker Worker)
        {
            if (id != Worker.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Worker);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkerExists(Worker.ID))
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
            ViewData["CuentaUsuarioID"] = new SelectList(_context.CuentaUsuario, "ID", "Email", Worker.CuentaUsuarioID);
            return View(Worker);
        }

        // GET: Workers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Worker = await _context.Worker
                .Include(t => t.CuentaUsuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Worker == null)
            {
                return NotFound();
            }

            return View(Worker);
        }

        // POST: Workers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Worker = await _context.Worker.FindAsync(id);
            _context.Worker.Remove(Worker);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkerExists(int id)
        {
            return _context.Worker.Any(e => e.ID == id);
        }
    }
}
