using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Pantalla:Elemento
    {
        private int numerodeSerie;

        public Pantalla(string marca, string modelo, int numerodeSerie, int anioFabricacion, int pulgadas)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.numerodeSerie = numerodeSerie;
            AnioFabricacion = anioFabricacion;
            Pulgadas = pulgadas;
        }

        public int AnioFabricacion { get; set; }
        public Nullable<int> Pulgadas { get; set; }
        public bool EsNueva ()
        {
            if (AnioFabricacion == DateTime.Today.Year)
                return true;
            else
                return false;
        }
        public override string DescripcionPorTipo()
        {
            if (Pulgadas.HasValue==true)
            return $"MONITOR{ marca} - { modelo} - { Pulgadas}";
            return $"MONITOR{ marca} - { modelo}";
        }
}
}
