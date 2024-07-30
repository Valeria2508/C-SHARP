using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Repaso.models
{
    public class Profesor: Persona // SE HEREDA PROFESOR DE PERSONA
    {
        public string Asignatura { get; set; }
        private double Salario { get; set;}
        public DateTime FechaContratacion { get; set;}
        public List<string> Cursos { get; set; } = new List<string> ();


        // SE CREA CONSTRUCTOR YA QUE UN PROFESOR SE CREA, Y LOS ATRIBUTOS DEL PADRE TAMBIEN SE PONEN YA QUE HEREDA

        public Profesor(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono,string asignatura, double salario, DateTime fechacontratacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento= numeroDocumento;
            Email = email;
            Telefono = telefono;
            Asignatura = asignatura;
            Salario = salario;
            FechaContratacion = fechacontratacion;
            Cursos = new List<string>();
        }

        //  PROCEDO A CREAR LOS METODOS
        public int CalcularAntiguedad(){
            DateTime fechaActual = DateTime.Now; // sacar la fcha de hoy
            int antiguedad = (fechaActual.Year - FechaContratacion.Year)*12 + fechaActual.Month - fechaActual.Month;// compara los tiempos para saber que tan vuejo es el empleado
            return antiguedad;
        }

        public void ObtenerSalario(){
            Console.WriteLine($"Su salario actual es de: {Salario}");
        }
        //###################  HASTA AQUI LLEGARON LOS METODS DE PROFESOR PLANTEADOS EN EL UML ###################
    }
}