using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class UtilidadCadena  
    {
        public static void Reverso(){
            Console.WriteLine("ingrese un texto");
            string cadena = Console.ReadLine();
            Console.WriteLine("El texto original es:"+cadena+ "El texto invertido es: " + new string(cadena.Reverse().ToArray()));
        }
    }
}