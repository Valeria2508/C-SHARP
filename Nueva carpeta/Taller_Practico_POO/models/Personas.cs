using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.models
{
    public class Personas
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }


        public Personas(string nombre, string apellido, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad ;
        }

        public void Saludar(){
            Console.WriteLine($"Hola {Nombre}, ten un excelente día hoy");
        }
    }
}