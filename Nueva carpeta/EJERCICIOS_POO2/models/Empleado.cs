using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIOS_POO2.models
{
    public class Empleado
    {
        private Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public double SueldoBase { get; set; }
        public double PorcentajeSalud {get;set;}
        public double PorcentajePension { get; set; }
        private double PorcentajeAhorroCoorporativa { get; set; }


        public Empleado( string nombre, string apellido, string correo, double sueldoBase,double porcentajeSalud, double porcentajePension, double porcentajeAhorroCoorporativa)
        {
            this.Id = Guid.NewGuid();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Correo = correo;
            this.SueldoBase = sueldoBase;
            this.PorcentajeSalud=porcentajeSalud;
            this.PorcentajePension = porcentajePension;
            this.PorcentajeAhorroCoorporativa = porcentajeAhorroCoorporativa;
        }
    

    private double CalcularAhorro(){
        return SueldoBase * PorcentajeAhorroCoorporativa /100;
    }
    private double CalcularDeducciones(){
        return (SueldoBase * PorcentajePension / 100) + (SueldoBase * PorcentajeSalud /100);
    }

    public double CalcularSueldoEmpleado(){
        return SueldoBase - CalcularDeducciones() - CalcularAhorro();
    }
    public void SaludarEmpleado(){
        Console.WriteLine($"hola {Nombre} Bienvenida/o a la empresa");
    }

    

    }
  
}