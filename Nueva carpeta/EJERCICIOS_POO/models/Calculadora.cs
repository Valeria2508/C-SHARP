using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;
//Crea una clase Calculadora con un método Sumar(int a, int b) que devuelva la suma de dos números.

public class Calculadora{
    public int a { get; set; }
    public int b { get; set; }
    public int suma { get; set; }
    public int resta {get; set;}

    public int Suma(){
        int a=50;
        int b=30;
        suma = a+b;
        return suma;
    }
//Añade un método Restar(int a, int b) a la clase Calculadora que devuelva la resta de dos números.
    public int Resta(){
        int a = 2;
        int b = 50;
        resta = a-b;
        return resta;
    }
}
