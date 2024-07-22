using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;

//Crea una clase Circulo con una propiedad Radio
public class Circulo{
    public double Radio {get;set;}

    //Añade un método CalcularCircunferencia() que devuelva la circunferencia del círculo.

    public double CalcularCircunferencia(){
        double pi=Math.PI;
        return pi*Radio;    
    }
}
