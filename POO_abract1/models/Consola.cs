using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abract1.models
{
    public class Consola
    {
        public static void CambioColor(){
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Color de fondo cambiado a verde");
            Console.ResetColor();
        }
    }
}