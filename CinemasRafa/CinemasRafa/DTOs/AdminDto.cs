using System.ComponentModel.DataAnnotations;

namespace CinemasRafa.DTOs
{
    public class AdminDto
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Nombre usuario")]
        [StringLength(10, MinimumLength = 2, ErrorMessage = "El nombre de usuario debe tener entre 2 y 10 caracteres.")]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,22}$",
         ErrorMessage = "La contraseña debe tener al menos una letra mayúscula, una minúscula, un número y un carácter especial.")]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50, ErrorMessage = "El email no puede superar los 50 caracteres.")]
        public string Email { get; set; }

        [Required]
        public bool Active { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(20, ErrorMessage = "El nombre no puede superar los 20 caracteres.")]
        public string Name { get; set; }

        [Display(Name = "Apellidos")]
        [Required]
        [StringLength(80, ErrorMessage = "El apellido no puede superar los 80 caracteres.")]
        public string Surname { get; set; }


        [Required]
        [Display(Name = "Telefono")]
        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "Telefono no valido.")]
        public string Phone { get; set; }
    }
}
