using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemasRafa.Models
{
    public class CuentaUsuario
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre usuario")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "Error el usuario debe tener entre 2 y 10 caracteres.")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,22}$",
         ErrorMessage = "Contraseña debe tener al menos una letra mayúscula, una minúscula, un número y un carácter especial.")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "Email no puede superar 50 caracteres.")]

        public string Email { get; set; }

        [Required]
        public bool Active { get; set; }

        public int RoleID { get; set; }

        [ForeignKey("RoleID")]
        public Role Role { get; set; }
    }
}
