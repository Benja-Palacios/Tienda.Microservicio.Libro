using FluentValidation;
using MediatR;
using System.Data;
using Tienda.Microservicio.Libro.Modelo;
using Tienda.Microservicio.Libro.Persistencia;

namespace Tienda.Microservicio.Libro.Aplicacion
{
    public class Nuevo
    {
        public class Ejecuta : IRequest
        {
            public string Titulo { get; set; }
            public DateTime? FechaPublicacion { get; set; }
            public Guid? AutorLibro { get; set; }
            public String Genero { get; set; }
            public double Precio { get; set; }
        }

        public class EjecutaValidation : AbstractValidator<Ejecuta>
        {
            public EjecutaValidation()
            {
                RuleFor(x => x.Titulo).NotEmpty();
                RuleFor(x => x.FechaPublicacion).NotEmpty();
                RuleFor(x => x.AutorLibro).NotEmpty();
                RuleFor(x => x.Genero).NotEmpty();
                RuleFor(x => x.Precio).NotEmpty();
            }

            public class Manejador : IRequestHandler<Ejecuta>
            {
                private readonly ContextoLibreria _contexto;

                public Manejador(ContextoLibreria contexto)
                {
                    _contexto = contexto;
                }

                public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
                {
                    var libro = new LibreriaMaterial
                    {
                        Titulo = request.Titulo,
                        FechaPublicacion = request.FechaPublicacion?.ToUniversalTime(),
                        AutorLibro = request.AutorLibro,
                        Genero = request.Genero,
                        Precio = request.Precio,
                    };

                    _contexto.LibreriaMaterial.Add(libro);
                    var valor = await _contexto.SaveChangesAsync();

                    if (valor > 0)
                    {
                        return Unit.Value;
                    }
                    throw new Exception("No se pudo guardar el libro");

                }
            }


        }

    }
}
