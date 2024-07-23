using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class BaseDatos 
    {
        public static string Conexion { get; set; } 

        static BaseDatos ()
        {
            Conexion = "conectado";
        }

        public static void MostrarConexion(){
            Console.WriteLine($"el estado de la conexion es: {Conexion}");
        }
    }
}