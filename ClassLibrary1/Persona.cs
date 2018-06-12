using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string fechaNacimiento { get; set; }
        public string biografia { get; set; }
        public string Display
        {
            get
            {
                return string.Format("{0}", nombre);
            }
        }

    }

}
