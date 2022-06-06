using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemasRafa.Models
{
    public class Role
    {
        public int ID { get; set; }

        [Display(Name = "Rol")]
        [Required]
        public string RoleName { get; set; }

        [Display(Name = "Descripcion")]
        [Required]
       
        public string RoleDescription { get; set; }

        public bool Enabled { get; set; }

        [InverseProperty("Role")]
        public List<CuentaUsuario> CuentaUsuarios { get; set; }
        [InverseProperty("Role")]
        public List<RoleHasMenu> RoleHasMenus { get; set; }
    }
}
