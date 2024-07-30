using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.models
{
    public class Oso : Animal
    {
        public bool Ivernar { get; set;}

        public Oso(string nombre, double peroKg, bool ivernar): base(nombre, peroKg)
        {
            Ivernar = ivernar;
        }

         public override void Respirar() // al recibir el metodo abstract, se pone override y se pone contenido al metodo y la clase no es abstract
        {
            Console.WriteLine($"{Nombre} respira lentamente");
        }
    }
}