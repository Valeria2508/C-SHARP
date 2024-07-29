using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abract1.models
{
    public class Animal
    {
        public int Id { get; set;}
        public string Nombre {get; set;}
        public int Edad { get; set;}
        public string Especie { get; set;}
        // private string especie2;
        // public string Especie2{
        //     get{return especie2}
        //     set { especie2 = value} forma antigua de abstraccion 
        // }
        public Animal(int id, string nombre, int edad, string especie)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Especie = especie;
        }

    }
}