using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_Polimorfismo.models
{
    public class Perro:Animal
    {
        public override void Hablar(){
            // base. accedo al metodo que estoy heredando
            base.Hablar(); //override hace referencia a que estoy usando el metodo de la clase que estoy heredando, (sobreescritura de metodo)
            Console.WriteLine("el perro dice wuaff");
        }
        public override void Desplazarse()
        {
            base.Desplazarse();
            Console.WriteLine("el pez de desplaza poco");
        }
    }
}