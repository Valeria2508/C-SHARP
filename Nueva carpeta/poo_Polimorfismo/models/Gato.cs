using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_Polimorfismo.models
{
    public class Gato:Animal
    {
        // public override void Hablar(){
        //     base.Hablar();//para que aparezcan ambos metodos
        //     Console.WriteLine("miau");
        // }

        // public override void Desplazarse()
        // {   base.Desplazarse();
        //     Console.WriteLine("el gato se desplaza");
        // }

        public double TamañoBigote { get; set; }
        public bool Orejas { get; set; }
        public void Presentar(){
            Console.WriteLine("hola a todos soy un gato y mi nombre es " + Nombre);
        }

        //contructor del hijo
        // public Gato(string nombre, string genero,string especie, double pesoKg, double tamañoBigotes, bool orejas):base(nombre, genero, especie, pesoKg)
        // {
        //     TamañoBigote=tamañoBigotes;
        //     Orejas=orejas;
        // }

    }
}