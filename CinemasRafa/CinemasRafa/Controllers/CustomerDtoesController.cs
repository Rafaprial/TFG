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
    //[ServiceFilter(typeof(WorkerFilter))]
    //[ServiceFilter(typeof(RecepcionistFilter))]
    public class CustomerDTOsController : Controller
    {
        private readonly ControlContext _context;

        public CustomerDTOsController(ControlContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Username,Password,Email,Active,Name,Surname,Phone,Address")] CustomerDto CustomerDto)
        {
            Role role = _context.Role.Where(r => r.RoleName == "Customer").FirstOrDefault();

            if (ModelState.IsValid)
            {
                Customer Customer = new Customer();
                CuentaUsuario cuenta = new CuentaUsuario();

                cuenta.Username = CustomerDto.Username;
                cuenta.Password = Utils.Encript(CustomerDto.Password);
                cuenta.Email = CustomerDto.Email;
                cuenta.RoleID = role.ID;
                cuenta.Active = CustomerDto.Active;

                _context.Add(cuenta);
                await _context.SaveChangesAsync();

                Customer.Name = CustomerDto.Name;
                Customer.Surname = CustomerDto.Surname;
                Customer.Phone = CustomerDto.Phone;
                Customer.Address = CustomerDto.Address;
                Customer.CuentaUsuarioID = cuenta.ID;
                _context.Add(Customer);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }

            return View(CustomerDto);
        }
    }
}
