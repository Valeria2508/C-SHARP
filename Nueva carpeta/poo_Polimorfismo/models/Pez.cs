using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_Polimorfismo.models
{
    public class Pez: Animal
    {
        public override void Desplazarse(){
            base.Desplazarse();
            Console.WriteLine("el pez se desplazo mucho, vaya duera");
        }
        public override void Hablar()
        {
            base.Hablar();
            Console.WriteLine("el pez dice gogo");
        }
    }
}