using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abract1.models
{
    public abstract class Persona
    {
        public string Nombre { get; set;}
        public int Edad { get; set;}
        public string Ocupacion { get; set;}

        public Persona(string nombre, int edad, string ocupacion)
        {
            Nombre = nombre;
            Edad = edad;
            Ocupacion = ocupacion;
        }

        public abstract void MostrarInformacion();

    }
}