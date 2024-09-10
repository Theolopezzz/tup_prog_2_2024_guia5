using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5_Ejercicio_Parcial.Models
{
    internal class Presupuesto
    {
        ArrayList listaProductos = new ArrayList();             
        public double Precio { get; }
        public Presupuesto(string nombre,string direccion) 
        { 
            Cliente solicitante = new Cliente(nombre, direccion);
        }
        public void AgregarCliente(Producto unProducto)
        {
            listaProductos.Add(unProducto);
        }
        public bool QuitarProducto(int codigo)
        {
            bool eliminado = false;    
            Producto producto = BuscarProducto(codigo);
            if (producto != null)
            {
                listaProductos.Remove(producto);
                eliminado = true;
            }
            return eliminado;
        }
        private Producto BuscarProducto(int codigo)
        {
            listaProductos.Sort();
            int buscado=listaProductos.BinarySearch(codigo);
            return listaProductos[buscado] as Producto;
        } 
        public string[] Resumen()
        {

        }
    }
}
