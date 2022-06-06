using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace CinemasRafa.Models
{
    public class Peliculas
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaEstreno { get; set; }
        public double Precio { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        [ValidateNever]
        public Categoria Categoria { get; set; }
        [Required]
        [Display(Name = "Pegi")]
        public int PegiId { get; set; }
        [ValidateNever]
        public Pegi Pegi { get; set; }


    }
}
