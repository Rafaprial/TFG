using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.ComponentModel.DataAnnotations;

namespace CinemasRafa.Models
{
    public class Series
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Director { get; set; }
        public string Temporada { get; set; }
        public DateTime FechaEstreno { get; set; }
        public bool HaTerminado { get; set; }
        public string UrlDescarga { get; set; }
        public double Valoracion { get; set; }

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
