using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class CalculadoraAritmetica 
    {
         //metodo suma
        public static double Sumar(double numUno, double numDos){
            return numUno + numDos;
        }
        //metodo resta
        public static double Restar(double numUno, double numDos){
            return numUno - numDos;
        }

        //metodo multiplicacion
        public static double multiplicar(double numUno, double numDos){
            return numUno * numDos;
        }

        //metodo division
        public static double Dividir(double numUno, double numDos){
            return numUno / numDos;
        }
    }
}