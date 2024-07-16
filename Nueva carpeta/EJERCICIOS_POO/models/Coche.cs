using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;

//Crea una clase Coche con propiedades Marca, Modelo y Año.
    public class Coche{
    public string Marca { get; set; }
    public int Modelo { get; set; }
    public int Anio { get; set; }
    public int nuevoAño { get; set; }
//Añade un método MostrarDetalles() a la clase Coche que imprima los detalles del coche.
    public void MostrarDetalles(){
        Console.WriteLine($"Marca {Marca} modelo {Modelo} año{Anio}");
    }

    // Añade un método ActualizarAño(int nuevoAño) a la clase Coche que actualice la propiedad Año.

    public void ActualizarAño(){
        nuevoAño =2022;
        Anio = nuevoAño;
        Console.WriteLine($"el año actualizado del carro es {Anio}");
    }
}
