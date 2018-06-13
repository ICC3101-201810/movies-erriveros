using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pelicula
    {
        public string nombre { get; set; }
        public Director director { get; set; }

        public string FechaEstreno { get; set; }
        public string descripcion { get; set; }

        public double presupuesto { get; set; }

        public Estudio estudio { get; set; }
        
        public Critica critica { get; set; }

        public string DisplayP
        {
            get
            {
                return string.Format("{0}", nombre);
            }
        }
        
    }
}
