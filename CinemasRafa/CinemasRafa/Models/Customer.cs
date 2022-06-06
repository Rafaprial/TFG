using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CinemasRafa.Models
{
    public class Customer: Persona
    {
        [Required]
        [Display(Name = "Direccion")]
        [StringLength(40, ErrorMessage = "La direccion no puede superar los 40 caracteres.")]
        public string Address { get; set; }


    }
}
