using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using CinemasRafa.Data;
using System;
using System.Linq;

namespace CinemasRafa.Filters
{
    public class WorkerFilter : IActionFilter
    {
        private readonly ControlContext _context;

        public WorkerFilter(ControlContext context)
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

            if (role.ID > 2)
            {
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }

        }
    }
}