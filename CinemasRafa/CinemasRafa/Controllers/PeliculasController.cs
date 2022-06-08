using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemasRafa.Data;
using CinemasRafa.Models;
using CinemasRafa.Filters;

namespace CinemasRafa.Controllers
{
    public class PeliculasController : Controller
    {
        private readonly ControlContext _context;

        public PeliculasController(ControlContext context)
        {
            _context = context;
        }


        // GET: Peliculas
/*        public async Task<IActionResult> Index()
        {
            var controlContext = _context.Peliculas.Include(p => p.Categoria).Include(p => p.Pegi);
            return View(await controlContext.ToListAsync());
        }
*/
        public async Task<IActionResult> Index(string searchString)
        {
            var movies = from m in _context.Peliculas
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Nombre.Contains(searchString));
            }
            movies.Include(p => p.Categoria).Include(p => p.Pegi);
            return View(await movies.ToListAsync());
        }

        // GET: Peliculas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas
                .Include(p => p.Categoria)
                .Include(p => p.Pegi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (peliculas == null)
            {
                return NotFound();
            }

            return View(peliculas);
        }
        [ServiceFilter(typeof(WorkerFilter))]

        // GET: Peliculas/Create
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id");
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id");
            return View();
        }
        [ServiceFilter(typeof(WorkerFilter))]
        // POST: Peliculas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Descripcion,Director,Duracion,FechaEstreno,UrlDescarga,Valoracion,ImageUrl,CategoriaId,PegiId")] Peliculas peliculas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(peliculas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id", peliculas.CategoriaId);
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id", peliculas.PegiId);
            return View(peliculas);
        }

        // GET: Peliculas/Edit/5
        [ServiceFilter(typeof(WorkerFilter))]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas.FindAsync(id);
            if (peliculas == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id", peliculas.CategoriaId);
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id", peliculas.PegiId);
            return View(peliculas);
        }
        [ServiceFilter(typeof(WorkerFilter))]
        // POST: Peliculas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Descripcion,Director,Duracion,FechaEstreno,UrlDescarga,Valoracion,ImageUrl,CategoriaId,PegiId")] Peliculas peliculas)
        {
            if (id != peliculas.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(peliculas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PeliculasExists(peliculas.Id))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id", peliculas.CategoriaId);
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id", peliculas.PegiId);
            return View(peliculas);
        }
        [ServiceFilter(typeof(WorkerFilter))]
        // GET: Peliculas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var peliculas = await _context.Peliculas
                .Include(p => p.Categoria)
                .Include(p => p.Pegi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (peliculas == null)
            {
                return NotFound();
            }

            return View(peliculas);
        }
        [ServiceFilter(typeof(WorkerFilter))]
        // POST: Peliculas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var peliculas = await _context.Peliculas.FindAsync(id);
            _context.Peliculas.Remove(peliculas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PeliculasExists(int id)
        {
            return _context.Peliculas.Any(e => e.Id == id);
        }
    }
}
