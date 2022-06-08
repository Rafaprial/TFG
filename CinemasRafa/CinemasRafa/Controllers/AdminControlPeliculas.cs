using CinemasRafa.Data;
using CinemasRafa.Filters;
using CinemasRafa.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CinemasRafa.Controllers
{
    public class AdminControlPeliculas : Controller
    {
        private readonly ControlContext _context;

        public AdminControlPeliculas(ControlContext context)
        {
            _context = context;
        }

        // GET: Peliculas
        [ServiceFilter(typeof(WorkerFilter))]
        public async Task<IActionResult> Index()
        {
            var controlContext = _context.Peliculas.Include(p => p.Categoria).Include(p => p.Pegi);
            return View(await controlContext.ToListAsync());
        }

    }
}
