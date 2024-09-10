using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5_Ejercicio_Parcial.Models
{
    internal abstract class Producto:IComparable
    {
        protected double precioBase;
        protected double largo;
        int codigo;
        public int Codigo { get { return codigo; } set {  codigo = value; } }
        public Producto(double precio, double largo)
        {
            precioBase= precio;
            this.largo= largo;
        }
        abstract public double Peso();
        abstract public double Precio();

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                Producto compararProducto = obj as Producto;
                return codigo.CompareTo(compararProducto.Codigo);
            }
            return 0;
        }

    }
}
