using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class Configuracion
    {
        public static bool ModoOscuro  { get; set; } = false;


        public static void CambiarModo(){
            ModoOscuro=true;
            Console.WriteLine($"El modo actual de modo oscuro es {ModoOscuro}");
        }

    }
}