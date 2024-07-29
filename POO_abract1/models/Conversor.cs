using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abract1.models
{
    public static class Conversor
    {
        public static int ConvertirGrado { get; set; }

        public static double ConvertirFahrenheitACelsius()
        {
            double celsius = (50 - 32) * 5 / 9;
            return celsius;
        }
    }   
}