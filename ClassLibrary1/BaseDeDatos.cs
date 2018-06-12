using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BaseDeDatos
    {
        public List<Pelicula> peliculas { get; set; }
        public List<Persona> personas { get; set; }
        public List<Productor> productores { get; set; }
        public List<Actor> actores { get; set; }
        public List<Director> directores { get; set; }
        public List<Estudio> estudios { get; set; }

        public List<PeliculaActor> peliculaActor { get; set; }
        public List<PeliculaProductor> peliculaProductor { get; set; }



    }
}
