using System.ComponentModel.DataAnnotations;

namespace CinemasRafa.Models
{
    public class Comida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        [Range(0,5)]
        public int Valoraciones { get; set; }
    }
}
