using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5_Ejercicio_Parcial.Models
{
    internal class Banco:Producto
    {
        public Banco(double precio, double largo) : base (precio, largo)
        {

        }
        override public double Peso()
        {
            return (largo*0.25)*0.42;
        }
        
        override public double Precio()
        {
            return Peso() * precioBase * 1.15;
        }
    }
}
