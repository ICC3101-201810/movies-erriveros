using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Estudio
    {
        public string direcion { get; set; }
        public string nombre { get; set; }
        public string fechaApertura { get; set; }

        public string DisplayE
        {
            get
            {
                return string.Format("{0}", nombre);
            }
        }
    }
}
