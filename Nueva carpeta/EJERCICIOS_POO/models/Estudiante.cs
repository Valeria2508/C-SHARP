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
    public int GetEdad(){
        return Edad;
    } 
    public int SetEdad(int edad){
        
    }
}
