using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CinemasRafa.Data;
using CinemasRafa.Models;
using CinemasRafa.Util;
using System.Collections.Generic;
using System.Linq;

namespace CinemasRafa.Controllers
{
    public class LoginController : Controller
    {
        private readonly ControlContext _context;

        public LoginController(ControlContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string username, string password)
        {
            if (password != null)
            {
                string encriptedPass = Utils.Encript(password);
                var usuario = _context.CuentaUsuario.Where(u => u.Username == username && u.Password == encriptedPass).FirstOrDefault();

                if (usuario != null)
                {
                    if(usuario.Active == false)
                    {
                        TempData["ErrorMessage"] = "Su cuenta ha sido suspendida.";
                        return RedirectToAction(nameof(Index));
                    }
                    HttpContext.Session.SetString("usuario", usuario.ID.ToString());
                    HttpContext.Session.SetString("username", usuario.Username.ToString());

                    var rol = _context.Role.Where(r => r.ID.Equals(usuario.RoleID)).FirstOrDefault();
                    HttpContext.Session.SetString("rol", rol.RoleName.ToString());

                    Utils.Menus = _context.RoleHasMenu.Include(m => m.Menu).Where(m => m.RoleID == usuario.RoleID).Select(m => m.Menu).ToList();
                    string labels = string.Empty;
                    string controllers = string.Empty;
                    string actions = string.Empty;
                    foreach(Menu menu in Utils.Menus)
                    {
                        labels += menu.Label + ",";
                        controllers += menu.Controller + ",";
                        actions += menu.Action + ",";

                    }
                    HttpContext.Session.SetString("labels", labels);
                    HttpContext.Session.SetString("controllers", controllers);
                    HttpContext.Session.SetString("actions", actions);

                }
                else
                {
                    TempData["ErrorMessage"] = "Error en login. Error en usuario o contraseña.";
                    return RedirectToAction(nameof(Index));
                }

            }
            else
            {
                TempData["ErrorMessage"] = "Debe rellenar los campos para continuar.";
                return RedirectToAction(nameof(Index));
            }
            
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            //Session.Clear

            Utils.Menus = new List<Menu>();
            return RedirectToAction("Index", "Login");
        }
    }
}
