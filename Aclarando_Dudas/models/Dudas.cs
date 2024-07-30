using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aclarando_Dudas.models
{
    public class Dudas : DudasPadre // se hereda hijo: padre
    {
        //    EXISTEN VARIOS TIPOS DE MODIFICADORES DE ACCESO
        //  PUBLIC: ACCESIBILIDAD COMPLETA
        // PRIVATE: ACCESIBLE SOLO DESDE LA MISMA CALSE
        // PROTECTED: ACCESIBLE SOLO DESDE LA CLASE Y SUS CLASES HIJAS -> ESTA SE HEREDA
        public string Nombre { get; set; } //se usa en cualquier parte
        private int Cedula { get; set; } // solo la uso en esta clase
        protected int Edad { get; set; } // se usa en esta clase y en otra solo si se hereda


        public Dudas(string nombre, int cedula, int edad)
        {
            Nombre = nombre;
            Cedula = cedula;
            Edad = edad;
        }


    }
}