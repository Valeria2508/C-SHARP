using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.models
{
    public abstract class Animal
    {
        public string Nombre {get;set;}
        public double PesoKg {get;set;}

        public Animal(string nombre, double pesoKg)
        {
            Nombre = nombre;
            PesoKg = pesoKg;
        }

        public  void Comer()
        {
            Console.WriteLine($"{Nombre} come.");
        }

        public  void Dormir()
        {
            Console.WriteLine($"{Nombre} duerme.");
        }

        public  void Caminar()
        {
            Console.WriteLine($"{Nombre} se mueve.");
        }

        public abstract void Respirar(); // NO se pone conntenido al metodo abtracto
        // si algun metodo o atributo es abrast, la clase tambien lo debe de ser
        //  LOS METODOS ABSTRACT SON OBLIGATORIOS PARA LOS HIJOS, pero cuando se hereda normal sin abstract, solo los atributos y el constructor del padre, lo debe tener el hijo, los metodos son opcional 


    }
}