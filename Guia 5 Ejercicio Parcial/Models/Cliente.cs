using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5_Ejercicio_Parcial.Models
{
    internal class Cliente
    {
        string nombre;
        string direccion;
        public Cliente (string nom, string dir)
        {
            nombre = nom;
            direccion = dir;    
        }
        public string ToString()
        {
            return $"Nombre: {nombre} \n\rDirección: {direccion}";
        }
    }
}
