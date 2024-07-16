using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;

//Crea una clase Persona con propiedades Nombre y Edad
public class Persona{
    public string Nombre{get;set;}
    public int Edad{get;set;}

    //Añade un método Saludar() a la clase Persona que imprima "Hola, mi nombre e [Nombre]"
    public void Saludar(){
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }


    //Añade un constructor a la clase Persona que acepte Nombre y Edad como parámetros.

    //constructor
    public Persona(string nombre, int edad){
        this.Nombre=nombre.ToLower();// Modifica la clase Persona para que el nombre siempre se almacene en minúsculas.
        this.Edad=edad;
    }
    //Añade un método MostrarDetalles() que imprima el nombre y la edad.
    public void MostrarDetalles() {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años");
    }
}
