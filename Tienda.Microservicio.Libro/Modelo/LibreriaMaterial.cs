using System.ComponentModel.DataAnnotations;

namespace Tienda.Microservicio.Libro.Modelo
{
    public class LibreriaMaterial
    {
        [Key]
        public Guid? LibreriaMaterialId { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set;}
        public Guid? AutorLibro { get; set; }
    }
}
