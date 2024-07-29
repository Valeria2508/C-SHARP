using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_abract1.models
{
    public class Empleado : Persona
    {
        public double Salario { get; set;}

        public Empleado(string nombre, int edad, string ocupacion, double salario): base(nombre, edad, ocupacion)
        {
            Salario = salario;
        }

        public override void MostrarInformacion(){
            Console.WriteLine($@"
            Nombre: {Nombre}
            Edad: {Edad}
            Ocupación: {Ocupacion}
            Salario: {Salario}");   
        }
    }
}