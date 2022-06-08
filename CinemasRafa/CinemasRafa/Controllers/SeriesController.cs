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
    public class SeriesController : Controller
    {
        private readonly ControlContext _context;

        public SeriesController(ControlContext context)
        {
            _context = context;
        }

        // GET: Series
        /*        public async Task<IActionResult> Index()
                {
                    var controlContext = _context.Serie.Include(s => s.Categoria).Include(s => s.Pegi);
                    return View(await controlContext.ToListAsync());
                }*/
        public async Task<IActionResult> Index(string searchString)
        {
            var serie = from m in _context.Serie
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                serie = serie.Where(s => s.Nombre.Contains(searchString));
            }
            serie.Include(p => p.Categoria).Include(p => p.Pegi);
            return View(await serie.ToListAsync());
        }


        // GET: Series/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var series = await _context.Serie
                .Include(s => s.Categoria)
                .Include(s => s.Pegi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (series == null)
            {
                return NotFound();
            }

            return View(series);
        }

        // GET: Series/Create
        [ServiceFilter(typeof(WorkerFilter))]
        public IActionResult Create()
        {
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id");
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id");
            return View();
        }

        // POST: Series/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [ServiceFilter(typeof(WorkerFilter))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Director,Temporada,FechaEstreno,HaTerminado,UrlDescarga,Valoracion,ImageUrl,CategoriaId,PegiId")] Series series)
        {
            if (ModelState.IsValid)
            {
                _context.Add(series);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id", series.CategoriaId);
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id", series.PegiId);
            return View(series);
        }

        // GET: Series/Edit/5
        [ServiceFilter(typeof(WorkerFilter))]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var series = await _context.Serie.FindAsync(id);
            if (series == null)
            {
                return NotFound();
            }
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id", series.CategoriaId);
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id", series.PegiId);
            return View(series);
        }

        // POST: Series/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [ServiceFilter(typeof(WorkerFilter))]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Director,Temporada,FechaEstreno,HaTerminado,UrlDescarga,Valoracion,ImageUrl,CategoriaId,PegiId")] Series series)
        {
            if (id != series.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(series);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeriesExists(series.Id))
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
            ViewData["CategoriaId"] = new SelectList(_context.Categoria, "Id", "Id", series.CategoriaId);
            ViewData["PegiId"] = new SelectList(_context.Pegi, "Id", "Id", series.PegiId);
            return View(series);
        }
        [ServiceFilter(typeof(WorkerFilter))]

        // GET: Series/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var series = await _context.Serie
                .Include(s => s.Categoria)
                .Include(s => s.Pegi)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (series == null)
            {
                return NotFound();
            }

            return View(series);
        }
        [ServiceFilter(typeof(WorkerFilter))]
        // POST: Series/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var series = await _context.Serie.FindAsync(id);
            _context.Serie.Remove(series);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeriesExists(int id)
        {
            return _context.Serie.Any(e => e.Id == id);
        }
    }
}
