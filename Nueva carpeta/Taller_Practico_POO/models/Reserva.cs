using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.models
{
    public class Reserva
    {
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public string HabitacionReservada { get; set; }

        public Reserva(DateOnly fechaInicio, DateOnly fechaFin, string habitacionReservada)
        {
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            HabitacionReservada = habitacionReservada;
        }

      
    }
}