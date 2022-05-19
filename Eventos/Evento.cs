using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public class Evento:EventArgs
    {
        public List<string> DescripcionProductos { get; set; }
        public string Mensaje { get; set; }
        public int CantidadComputadoras { get; set; }
        public int CantidadMonitores { get; set; }

    }
}
