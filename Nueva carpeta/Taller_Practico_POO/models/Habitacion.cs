using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.models
{
    public class Habitacion
    {
        public int NroHabitacion { get; set;}
        public string TipoHabitacion {get; set;}
        

        public Habitacion(int nroHabitacion, string tipoHabitacion)
        {
            NroHabitacion = nroHabitacion;
            TipoHabitacion = tipoHabitacion;
        }
    }
}