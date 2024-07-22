using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_HERENCIA.models;
    public class Entrenador : PersonalTecnico{
        public byte ExperienciaEnAnios {get;set;}
        public byte CantidadTitulos {get;set;}
        private double Salario {get;set;}
        public string Nacionalidad {get;set;}

        public Entrenador(){
            Console.WriteLine("este es el constructor de un entrenador");
        }
    }
