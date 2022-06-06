using CinemasRafa.Models;
using System;
using System.Collections.Generic;

namespace CinemasRafa.Util
{
    public class Utils
    {
        public static List<Menu> Menus { get; set; } = new List<Menu>();

        public static string Encript(string clave)
        {
            string result;
            byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(clave);

            result = Convert.ToBase64String(encrypted);
            return result;
        }
    }
}
