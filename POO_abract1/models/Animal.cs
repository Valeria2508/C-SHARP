using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abract1.models
{
    public abstract class Animal //al tener la clase abtracta, no se puede instanciar ni aunque tenga algo estatico
    { //las clases estaticas no permiten heredar
        public  abstract int Id { get; set;}
        public  abstract string Nombre {get; set;}
        public  abstract int Edad { get; set;}
        public abstract  string Especie { get; set;} 


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
        //si se tiene el metodo abracto, la clase tambien lo debe de ser
        // si tengo algo abstracto, toda clase que here debe de tener los metodos que el padre tenga abracto
        public abstract void Saludar();

    }
}