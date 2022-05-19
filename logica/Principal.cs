using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Eventos;

namespace logica
{
    
    public sealed class Principal
    {
        public List<Pantalla> pantallas = new List<Pantalla>();
        public List<Computadora> computadoras = new List<Computadora>();
        List<Elemento> Elementos = new List<Elemento>();
        public EventHandler<Eventos.Evento> ElementoAgregadoOEliminado;
        public static Principal Instance = null;
        private Principal()
        {

        }
        public static Principal instance
        {
            get
            {
                if (Instance == null)
                    Instance = new Principal();
                return Instance;
            }
        }
       
        public void AgregarElemento(string marca, string modelo, int NumerodeSerie,string DescripcionProcesador, int CantidadMemoriaRam, string NombreFabricante, int Id )
        {
            int CantidadComputadoras = computadoras.Count;
            computadoras.Add(new Computadora(marca, modelo, NumerodeSerie, Id, DescripcionProcesador, CantidadMemoriaRam, NombreFabricante, ));
            LanzarEvento(ListaOrdenada(), "$ agregado ", computadoras.Count, pantallas.Count);
          
        }

        public void AgregarElemento(string marca, string modelo, int NumerodeSerie,int anioFabricacion, int Pulgadas)
        {
            pantallas.Add(new Pantalla(marca, modelo, NumerodeSerie, anioFabricacion, Pulgadas));
            LanzarEvento(ListaOrdenada(), "$ agregado ", computadoras.Count, pantallas.Count);
        }
       
        public Elemento BuscarElementoPorId(int Id)
        {
            foreach (var item in Elementos)
            {
                if (item.Id == Id)
                    return item;
               
            }
            return null;
        }
       public void EliminarElemento(int Id)
        {
            Elemento elementoABuscar = BuscarElementoPorId(Id);
            foreach (var item in Elementos)
            {
                if (elementoABuscar.Id == Id)
                    Elementos.Remove(elementoABuscar);
                if (computadoras.Find(x => x.Id == elementoABuscar.Id) != null)
                    computadoras.Remove(computadoras.Find(x => x.Id == elementoABuscar.Id));
                else
                {
                    if (pantallas.Find(x => x.Id == elementoABuscar.Id) != null)
                        Elementos.Remove(elementoABuscar);
                    pantallas.Remove(pantallas.Find(x => x.Id == elementoABuscar.Id));
 
                }
                LanzarEvento (ListaOrdenada(), null, computadoras.Count, pantallas.Count);
            }
        }
        public List<string> ListaOrdenada()
        {
            List<string> listaCompleta = new List<string>();
            foreach (var item in Elementos)
            {
                listaCompleta.Add(item.DescripcionPorTipo());
                
            }
            return listaCompleta;
        }
      

        private void LanzarEvento(List<string> DescripcionProductos, string mensaje, int cantidadpantallas, int cantidadcomputadoras)
        {
            if(ElementoAgregadoOEliminado!=null)
            this.ElementoAgregadoOEliminado(this, new Evento() { DescripcionProductos = DescripcionProductos, CantidadMonitores=cantidadpantallas, CantidadComputadoras=cantidadcomputadoras, Mensaje=mensaje }) ;
        }

}
}
