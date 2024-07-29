using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abract1.models
{
    public class Perro: Animal
    {
        public bool EsCriollo { get; set; }

        public Perro(int id, string nombre, int edad, string especie, bool escriollo): base(id, nombre, edad, especie)
        {
            EsCriollo = escriollo;
        }

        public override void Saludar(){
            Console.WriteLine($"hola {Nombre}");
        }
    }
}