namespace Tienda.Microservicio.Libro.Aplicacion
{
    public class LibroMaterialDto
    {
        public Guid? LibreriaMaterialId {get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public String Genero { get; set; }
        public double Precio { get; set; }
        public Guid? AutorLibro { get; set; }
    }
}
