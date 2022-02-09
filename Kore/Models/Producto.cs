
using System.ComponentModel.DataAnnotations;
namespace Kore.Models
{
    public class Producto
    {
        public int id { get; set; }
        public string? Marca { get; set; }
        public string? Genero { get; set; }
        public string? Talla { get; set; }
        public string? Temporada { get; set; }
        public float? Precio { get; set; }
    }
}