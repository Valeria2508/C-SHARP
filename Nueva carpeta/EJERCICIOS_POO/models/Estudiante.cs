using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;

//Crea una clase Estudiante con propiedades Nombre, Edad y Grado.

public class Estudiante{
    public string Nombre {get;set;}
    public int Edad {get;set;}
    public int Grado {get;set;}

    //Añade métodos GetEdad() y SetEdad(int edad) a la clase Estudiante para acceder y modificar la edad.
    public void GetEdad(){
        Console.WriteLine($"la edad del estudiante es{this.Edad}");
    } 
    public void SetEdad(int edad){
        this.Edad=edad;
        //Usa estos métodos para cambiar la edad y mostrar el valor actualizado.

        Console.WriteLine($"la edad actualizada del estudiante es {this.Edad}");
    }
}
