using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS;

public class Convertidor{

    public static int Celsius { get; set;}
    public static int Fahrenheit { get; set;}
    
    public static void CelsiusAFahrenheit (){
        Fahrenheit = (Celsius * 9 / 5) + 32;
    }
}
