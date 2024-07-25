using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_Polimorfismo.models
{
    public class Animal
    {
        public Guid Id { get; set; }
        protected string Nombre { get; set; }
        public string Genero { get; set; }
        public string Especie { get; set; }
        public double PesoKg { get; set; }

        public Animal(string nombre, string genero,string especie, double pesoKg)
        {
            Id = Guid.NewGuid();// para id aleatorio
            Nombre = nombre;
            Genero = genero;
            Especie = especie;
            PesoKg = pesoKg;
        }

        public virtual void Hablar(){//permine que sobre escriba el metodo
            Console.WriteLine("El animal esta hablando");
        }

        public virtual void Desplazarse(){
            Console.WriteLine("el animal se quedo dormido, ni modo");
        }

       
    }
}