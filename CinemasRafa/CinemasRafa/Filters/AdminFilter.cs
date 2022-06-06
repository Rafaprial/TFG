using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using CinemasRafa.Data;
using System;
using System.Linq;
using CinemasRafa.Models;

namespace CinemasRafa.Filters
{
    public class AdminFilter : IActionFilter
    {
        private readonly ControlContext _context;

        public AdminFilter(ControlContext context)
        {
            _context = context;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var user = _context.CuentaUsuario.Where(u => u.ID == Convert.ToInt32(context.HttpContext.Session.GetString("usuario"))).FirstOrDefault();
            var role = _context.Role.Where(r => r.ID == user.RoleID).FirstOrDefault();

            if (role == null || user == null)
            {
                context.Result = new RedirectToActionResult("Index", "Login", null);

            }

            if (role.RoleName != "Admin")
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }

        }
    }
}