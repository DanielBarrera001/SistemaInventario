using System.ComponentModel.DataAnnotations;

namespace SistemaInventario.Models
{
    public class Proveedor
    {
        public int Id { get; set; }
        [StringLength(250)]
        [Required]
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        public  ICollection<Producto> Productos { get; set; }
    }
}
