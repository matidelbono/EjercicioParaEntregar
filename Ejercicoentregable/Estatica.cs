using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejercicoentregable
{
    public static class Estatica
    {
        public static bool RamBienCargada(this int CantidadRam )
        {
            if (CantidadRam == 2 || CantidadRam == 4 || CantidadRam == 8 || CantidadRam == 16)
                return true;
            return false;
        }
    }
}
