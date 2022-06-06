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
    public class CuentaUsuariosController : Controller
    {
        private readonly ControlContext _context;

        public CuentaUsuariosController(ControlContext context)
        {
            _context = context;
        }

        // GET: CuentaUsuarios
        public async Task<IActionResult> Index()
        {
            var controlContext = _context.CuentaUsuario.Include(c => c.Role);
            return View(await controlContext.ToListAsync());
        }

        // GET: CuentaUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuentaUsuario = await _context.CuentaUsuario
                .Include(c => c.Role)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cuentaUsuario == null)
            {
                return NotFound();
            }

            return View(cuentaUsuario);
        }

        // GET: CuentaUsuarios/Create
        public IActionResult Create()
        {
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription");
            return View();
        }

        // POST: CuentaUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Username,Password,Email,Active,RoleID")] CuentaUsuario cuentaUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cuentaUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription", cuentaUsuario.RoleID);
            return View(cuentaUsuario);
        }

        // GET: CuentaUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuentaUsuario = await _context.CuentaUsuario.FindAsync(id);
            if (cuentaUsuario == null)
            {
                return NotFound();
            }
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription", cuentaUsuario.RoleID);
            return View(cuentaUsuario);
        }

        // POST: CuentaUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Username,Password,Email,Active,RoleID")] CuentaUsuario cuentaUsuario)
        {
            if (id != cuentaUsuario.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cuentaUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CuentaUsuarioExists(cuentaUsuario.ID))
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
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription", cuentaUsuario.RoleID);
            return View(cuentaUsuario);
        }

        // GET: CuentaUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cuentaUsuario = await _context.CuentaUsuario
                .Include(c => c.Role)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cuentaUsuario == null)
            {
                return NotFound();
            }

            return View(cuentaUsuario);
        }

        // POST: CuentaUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cuentaUsuario = await _context.CuentaUsuario.FindAsync(id);
            _context.CuentaUsuario.Remove(cuentaUsuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CuentaUsuarioExists(int id)
        {
            return _context.CuentaUsuario.Any(e => e.ID == id);
        }
    }
}
