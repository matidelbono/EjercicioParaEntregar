using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Elemento
    {
        public string marca{ get; set; }
        public string modelo { get; set; }
        public int NumeroSerie { get; set; }
        public int Id { get; set; }
        public abstract string DescripcionPorTipo();
  

    }
}
