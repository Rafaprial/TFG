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
    public class RoleHasMenusController : Controller
    {
        private readonly ControlContext _context;

        public RoleHasMenusController(ControlContext context)
        {
            _context = context;
        }

        // GET: RoleHasMenus
        public async Task<IActionResult> Index()
        {
            var controlContext = _context.RoleHasMenu.Include(r => r.Menu).Include(r => r.Role);
            return View(await controlContext.ToListAsync());
        }

        // GET: RoleHasMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleHasMenu = await _context.RoleHasMenu
                .Include(r => r.Menu)
                .Include(r => r.Role)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (roleHasMenu == null)
            {
                return NotFound();
            }

            return View(roleHasMenu);
        }

        // GET: RoleHasMenus/Create
        public IActionResult Create()
        {
            ViewData["MenuID"] = new SelectList(_context.Menu, "ID", "ID");
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription");
            return View();
        }

        // POST: RoleHasMenus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MenuID,RoleID")] RoleHasMenu roleHasMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(roleHasMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MenuID"] = new SelectList(_context.Menu, "ID", "ID", roleHasMenu.MenuID);
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription", roleHasMenu.RoleID);
            return View(roleHasMenu);
        }

        // GET: RoleHasMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleHasMenu = await _context.RoleHasMenu.FindAsync(id);
            if (roleHasMenu == null)
            {
                return NotFound();
            }
            ViewData["MenuID"] = new SelectList(_context.Menu, "ID", "ID", roleHasMenu.MenuID);
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription", roleHasMenu.RoleID);
            return View(roleHasMenu);
        }

        // POST: RoleHasMenus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MenuID,RoleID")] RoleHasMenu roleHasMenu)
        {
            if (id != roleHasMenu.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(roleHasMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoleHasMenuExists(roleHasMenu.ID))
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
            ViewData["MenuID"] = new SelectList(_context.Menu, "ID", "ID", roleHasMenu.MenuID);
            ViewData["RoleID"] = new SelectList(_context.Role, "ID", "RoleDescription", roleHasMenu.RoleID);
            return View(roleHasMenu);
        }

        // GET: RoleHasMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var roleHasMenu = await _context.RoleHasMenu
                .Include(r => r.Menu)
                .Include(r => r.Role)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (roleHasMenu == null)
            {
                return NotFound();
            }

            return View(roleHasMenu);
        }

        // POST: RoleHasMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var roleHasMenu = await _context.RoleHasMenu.FindAsync(id);
            _context.RoleHasMenu.Remove(roleHasMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoleHasMenuExists(int id)
        {
            return _context.RoleHasMenu.Any(e => e.ID == id);
        }
    }
}
