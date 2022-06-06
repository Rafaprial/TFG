using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemasRafa.Models
{
    public abstract class Persona
    {
        public int ID { get; set; }

        [Display(Name = "Apellidos")]
        [Required]
        [StringLength(80, ErrorMessage = "Apellido deberia de ser menor a 20 caracteres.")]
        public string Surname { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        [StringLength(20, ErrorMessage = "Nombre deberia de ser menor a 20 caracteres.")]
        public string Name { get; set; }


        public int CuentaUsuarioID { get; set; }

        [ForeignKey("CuentaUsuarioID")]
        public CuentaUsuario CuentaUsuario { get; set; }

        [Required]
        [Display(Name = "Telefono")]
        [RegularExpression(@"^[0-9]{9}$", ErrorMessage = "Telefono no valido.")]
        public string Phone { get; set; }



    }
}
