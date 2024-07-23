using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class Usuario 
    {
        public static int TotalUsuarios { get; set; }=0;

        public static void MostrarTotalUsuarios (){
            Console.WriteLine("deseas registrarte? ");
            var usuario = Console.ReadLine();
            if (usuario == "si".ToLower())
            {
                TotalUsuarios++;
                Console.WriteLine($"El total de usuarios es {TotalUsuarios}");
                
            }else
            {
                Console.WriteLine("totaol de usuarios "+TotalUsuarios);
            }
        }
    }
}