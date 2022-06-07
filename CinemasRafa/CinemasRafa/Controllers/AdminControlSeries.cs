using CinemasRafa.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CinemasRafa.Controllers
{
    public class AdminControlSeries : Controller
    {
        private readonly ControlContext _context;

        public AdminControlSeries(ControlContext context)
        {
            _context = context;
        }

        // GET: Series
        public async Task<IActionResult> Index()
        {
            var controlContext = _context.Serie.Include(s => s.Categoria).Include(s => s.Pegi);
            return View(await controlContext.ToListAsync());
        }

    }
}
