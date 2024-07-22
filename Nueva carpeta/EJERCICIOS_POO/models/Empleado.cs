using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;

//Crea una clase Empleado con propiedades Nombre, Puesto y Salario.

public class Empleado{
    public string Nombre {get;set;}
    public string Puesto {get;set;}
    public double Salario {get;set;}

    //Asegúrate de que el nombre siempre se almacene en minúsculas.
    //Añade un método MostrarDetalles() que imprima los detalles del empleado

    public void MostrarDetalles(){
        Console.WriteLine($"el nombre del empleado {Nombre.ToLower()}");
        Console.WriteLine($"el puesto del empleado {Puesto}");
        Console.WriteLine($"el salario del empleado {Salario}");
    }

}
