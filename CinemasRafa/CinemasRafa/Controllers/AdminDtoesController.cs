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
    [ServiceFilter(typeof(AdminFilter))]
    public class AdminDTOsController : Controller
    {
        private readonly ControlContext _context;

        public AdminDTOsController(ControlContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Username,Password,Email,Active,Name,Surname,Phone")] AdminDto adminDto)
        {
            Role role = _context.Role.Where(r => r.RoleName == "Admin").FirstOrDefault();
            if (ModelState.IsValid)
            {
                CuentaUsuario cuenta = new CuentaUsuario();
                Admin admin = new Admin();

                cuenta.Username = adminDto.Username;
                cuenta.Password = Utils.Encript(adminDto.Password);
                cuenta.Email = adminDto.Email;
                cuenta.RoleID = role.ID;
                cuenta.Active = adminDto.Active;

                _context.Add(cuenta);
                await _context.SaveChangesAsync();

                admin.Name = adminDto.Name;
                admin.Surname = adminDto.Surname;

                admin.Phone = adminDto.Phone;
                admin.CuentaUsuarioID = cuenta.ID;
                _context.Add(admin);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Admins");
            }
            return View(adminDto);
        }
    }
}
