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
        public double Precio 
        { 
            get
            {
                double total = 0;
                foreach (Producto p in listaProductos)
                {
                    total += p.Precio();
                }
                return total;
            }
        }
        private Cliente solicitante;
        public Presupuesto(string nombre,string direccion) 
        { 
            solicitante = new Cliente(nombre, direccion);
        }
        public void AgregarProducto(Producto unProducto)
        {
            listaProductos.Add(unProducto);
        }
        public bool QuitarProducto(int codigo)
        {   
            Producto producto = BuscarProducto(codigo);
            if (producto != null)
            {
                listaProductos.Remove(producto);
                return true;
            }
            return false;
        }
        public Producto BuscarProducto(int codigo)
        {
            listaProductos.Sort();
            Mesa buscada = new Mesa(1000, 20, 10, 5);
            buscada.Codigo = codigo;
            int buscado=listaProductos.BinarySearch(buscada);
            return listaProductos[buscado] as Producto;
        } 
        public string[] Resumen()
        {
            string[] resumen = new string[listaProductos.Count+2];
            int n = 0;
            resumen[n++]=solicitante.ToString();
            foreach (Producto a in listaProductos)
            {
                resumen[n++] = $"{a.Codigo}:  {a.Peso()}kg  ${a.Precio()} ";
            }
            resumen[n++] = $"Total: ${Precio}";
            return resumen;
        }
    }
}
