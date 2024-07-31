using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplo_POO_Interfaces.Interface;

namespace Ejemplo_POO_Interfaces.models
{
    public class Coder
    {   
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public int Edad {get;set;}
        public string Clan {get;set;}

        public Coder(string nombre, string apellido, int edad, string clan)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Clan = clan;
        }

    }
}