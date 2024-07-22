using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO.models;

//Crea una clase Rectangulo con propiedades Ancho y Alto.
public class Rectangulo{
    public double Ancho {get;set;}
    public double Alto {get;set;}
    public double Area {get;set;}

    //Añade un método CalcularArea() que devuelva el área del rectángulo.
    public double CalcularArea(){
        return Ancho*Alto;
    }

}
