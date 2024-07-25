using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.models
{
    public class Prenda
    {
        public string? Nombre { get; set; }
        public string? Talla { get; set; }
        public double Precio { get; set; }

        public Prenda(string nombre, string talla, double precio)
        {
            Nombre = nombre;
            Talla = talla;
            Precio = precio;
        }

    }
}