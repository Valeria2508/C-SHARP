using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS;

public class Contador{

    public static int TotalContadores { get; set; }

    public static void Incrementar(){
        Console.WriteLine("el contador aumento " + TotalContadores++ + " veces");
    }
}
