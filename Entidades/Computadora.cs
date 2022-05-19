using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Computadora:Elemento
    {
        private int numerodeSerie;

        public Computadora(string marca, string modelo, int numerodeSerie, int id, string descripcionProcesador, int cantidadMemoriaRam, string nombreFabricante, int cantidad)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.numerodeSerie = numerodeSerie;
            Id = id;
            DescripcionProcesador = descripcionProcesador;
            CantidadMemoriaRam = cantidadMemoriaRam;
            NombreFabricante = nombreFabricante;
            
        }

        public string DescripcionProcesador { get; set; }
        public int CantidadMemoriaRam { get; set; }
        public string NombreFabricante { get; set; }
        public int CantidadComputadoras { get; set; }
        public override string DescripcionPorTipo()
        {
            return $"PC {modelo} - {marca} - {DescripcionProcesador} - {CantidadMemoriaRam} Ram - {NombreFabricante}";
        }
    }
}
