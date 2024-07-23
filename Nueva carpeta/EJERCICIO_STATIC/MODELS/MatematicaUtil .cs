using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class MatematicaUtil 
    {
        //metodo suma
        public double Sumar(double num1, double num2){
            return num1 + num2;
        }
        //metodo resta
        public double Restar(double num1, double num2){
            return num1 - num2;
        }

        //metodo multiplicacion
        public double multiplicar(double num1, double num2){
            return num1 * num2;
        }

        //metodo division
        public double Dividir(double num1, double num2){
            return num1 / num2;
        }
    }
}