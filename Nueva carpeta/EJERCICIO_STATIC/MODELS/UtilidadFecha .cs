using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class UtilidadFecha 
    {
        public static void DiasEntreFechas (){
            DateTime fecha1 = new DateTime(2024, 12, 20);
            DateTime fecha2 = new DateTime(2024, 12, 24); 
            TimeSpan diferencia = fecha1 - fecha2;
            Console.WriteLine("la diferencia entre ambas fechas es: " + diferencia);
        }
    }
}