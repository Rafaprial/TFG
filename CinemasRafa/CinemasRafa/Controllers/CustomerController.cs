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
    [ServiceFilter(typeof(WorkerFilter))]
    
    public class CustomerController : Controller
    {
        private readonly ControlContext _context;

        public CustomerController(ControlContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            var controlContext = _context.Customer.Include(s => s.CuentaUsuario);
            return View(await controlContext.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Customer = await _context.Customer
                .Include(s => s.CuentaUsuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Customer == null)
            {
                return NotFound();
            }

            return View(Customer);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Customer = await _context.Customer.FindAsync(id);
            if (Customer == null)
            {
                return NotFound();
            }
            ViewData["CuentaUsuarioID"] = new SelectList(_context.CuentaUsuario, "ID", "Email", Customer.CuentaUsuarioID);
            return View(Customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Address,Email,ID,Name,Surname,Dni,Phone,CuentaUsuarioID")] Customer Customer)
        {
            if (id != Customer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(Customer.ID))
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
            ViewData["CuentaUsuarioID"] = new SelectList(_context.CuentaUsuario, "ID", "Email", Customer.CuentaUsuarioID);
            return View(Customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Customer = await _context.Customer
                .Include(s => s.CuentaUsuario)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (Customer == null)
            {
                return NotFound();
            }

            return View(Customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var Customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(Customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.ID == id);
        }
    }
}
