using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_HERENCIA.models;
    public class PersonalTecnico{
        private int Id {get;set;}
        public string Nombre {get;set;}
        public string Apellido {get;set;}
        public string TipoDocumento {get;set;}
        public string NumeroDocumento {get;set;}
        public DateOnly FechaNacimiento {get;set;}
        protected string RH {get;set;}
        public string TallaSuperior {get;set;}
        public string TallaInferior {get;set;}
        public byte TallaZapatos {get;set;}

        public byte CalcularEdad(){

            var today = DateOnly.FromDateTime(DateTime.Today);
            int age = today.Year - FechaNacimiento.Year;

            if (FechaNacimiento > today.AddYears(-age))
            {
                age--;
            }

            return Convert.ToByte(age);
        }

        // public string MostrarDetalle(){

        // }

    }