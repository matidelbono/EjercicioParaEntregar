using System;
using logica;
using Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicoentregable
{
    internal class Program
    {
        static void Main(string[] args)
    {
            Principal.instance.ElementoAgregadoOEliminado += ElementoAgregadoOEliminadoHandler;
            Console.WriteLine("ingrese el Nro de serie");
            int NroSerie = int.Parse(Console.ReadLine());
            while (NroSerie!=0)
            {
                Console.WriteLine("ingrese la marca");
                string marca = (Console.ReadLine());
                Console.WriteLine("ingrese el modelo");
                string modelo = (Console.ReadLine());
                Console.WriteLine("ingrese la opcion");
                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese el Anio ");
                        int Anio = int.Parse((Console.ReadLine());
                          Console.WriteLine("ingrese las pulgadas ");
                        Nullable<int> pulgadas = int.Parse((Console.ReadLine()));
                        break;
                    case 2:
                        Console.WriteLine("ingrese la descripcion del procesador");
                        string descripcion = Console.ReadLine();
                        Console.WriteLine("ingrese cantidad Ram");
                        int CantidadRam = int.Parse(Console.ReadLine());
                        string NombreFabricante = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("no puede ingresar otro elemento");
                        break;
                }
            }
    }
        static void ElementoAgregadoOEliminadoHandler(object sender, Eventos.Evento evento )
        {
            int Total = evento.CantidadComputadoras + evento.CantidadMonitores;
            Console.WriteLine("en el deposito hay" + evento.CantidadComputadoras, "computadoras y " + evento.CantidadMonitores, "monitores, siendo el porcentaje de computadoras" + evento.CantidadComputadoras*100/Total , "y el de pantallas" +evento.CantidadMonitores*100/Total);
        }
}
}
