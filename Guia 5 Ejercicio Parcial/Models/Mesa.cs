using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5_Ejercicio_Parcial.Models
{
    internal class Mesa:Producto
    {
        double ancho;
        double grosor;
        public Mesa(double precio, double largo, double ancho, double grosor): base(precio, largo)
        {
            this.ancho = ancho;
            this.grosor = grosor;
        }
        public override double Peso()
        {
            return largo * 0.25 * 0.3;
        }
        public override double Precio()
        {
            return Peso() * precioBase * 1.25;
        }
    }
}
