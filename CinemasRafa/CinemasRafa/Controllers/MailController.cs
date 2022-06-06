using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Net.Mail;

namespace CinemasRafa.Controllers
{
    public class MailController : Controller
    {
        // GET: Recuperacion
        public ActionResult Index()
        {
            return View();
        }
        public void enviarEMail(string correo, string password)
        {
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("info@cinemasrafa.com");
            Correo.To.Add(correo);
            Correo.Subject = ("Recuperar Contraseña Cinemas Rafa");
            Correo.Body = "Contraseña: \"" + password;
            Correo.Priority = MailPriority.Normal;

            SmtpClient ServerEmail = new SmtpClient();
            ServerEmail.Credentials = new NetworkCredential("info@cinemasrafa.com", "Administrados24@");
            ServerEmail.Host = "smtp.mail.com";
            ServerEmail.Port = 587;
            ServerEmail.EnableSsl = true;
            try
            {
                ServerEmail.Send(Correo);
            }
            catch (Exception e)
            {
            }
            Correo.Dispose();
        }
    }
}
