using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CinemasRafa.DTOs;
using CinemasRafa.Data;
using CinemasRafa.Models;
using CinemasRafa.Util;
using CinemasRafa.Filters;

namespace CinemasRafa.Controllers
{
    //[ServiceFilter(typeof(AdminFilter))]
    //[ServiceFilter(typeof(RecepcionistFilter))] Pensar quien puede crear profesores
    public class WorkerDTOsController : Controller
    {
        private readonly ControlContext _context;

        public WorkerDTOsController(ControlContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Username,Password,Email,Active,Name,Surname,Phone")] WorkerDto WorkerDto)
        {
            Role role = _context.Role.Where(r => r.RoleName == "Worker").FirstOrDefault();

            if (ModelState.IsValid)
            {
                Worker Worker = new Worker();
                CuentaUsuario cuenta = new CuentaUsuario();

                cuenta.Username = WorkerDto.Username;
                cuenta.Password = Utils.Encript(WorkerDto.Password);
                cuenta.Email = WorkerDto.Email;
                cuenta.RoleID = role.ID;
                cuenta.Active = WorkerDto.Active;

                _context.Add(cuenta);
                await _context.SaveChangesAsync();

                Worker.Name = WorkerDto.Name;
                Worker.Surname = WorkerDto.Surname;
                Worker.Phone = WorkerDto.Phone;
                Worker.CuentaUsuarioID = cuenta.ID;
                _context.Add(Worker);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(WorkerDto);
        }
    }
}
