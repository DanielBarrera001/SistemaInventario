using System.ComponentModel.DataAnnotations;

namespace SistemaInventario.Models
{
    public class Producto
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public double? Precio { get; set; } 
        public int Stock { get; set; }
        public string CodigoBarras { get; set; }
    }
}