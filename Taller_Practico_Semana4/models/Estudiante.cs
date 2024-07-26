using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_Semana4.models
{
    public class Estudiante:Persona //se heredo con persona
    {   //se crea atributos
        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set;}
        public DateOnly FechaNacimiento { get; set; }
        public List<double> Calificaciones { get; set;}

        //se crea constructor con : base para que se hereden los atributos de persona
        public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento)
        
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Email = email;
            Telefono = telefono;
            NombreAcudiente = nombreAcudiente;
            CursoActual = cursoActual;
            FechaNacimiento = fechaNacimiento;  
            // Calificaciones = new List<double>();
        }

        public void AgregarCalificacion(double Calificacion){
            Console.WriteLine("Ingrese su calificación");
            Calificaciones.Add(Calificacion);
            Console.WriteLine("Su calificacion se agregó correctamente");
        }

        private void CalcularPromedio(){
            Console.WriteLine($"El promedio de las notas del estudiantes es de: {Calificaciones.Average()}");
        }

        public int CalcularEdad(){
            int fechaActual = new DateOnly().Year;
            int edad = fechaActual - FechaNacimiento.Year;
            return edad;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine($@"Los estudiantes son:
            Nombre: {Nombre}
            Apellido: {Apellido}
            Tipo Documento: {TipoDocumento}
            Numero Documento: {NumeroDocumento}
            Email: {Email}
            Telefono: {Telefono}
            Nombre Acudiente: {NombreAcudiente}
            Curso Actual: {CursoActual}
            Fecha Nacimiento: {FechaNacimiento}
            Edad: {CalcularEdad()}");
        }
    }
}