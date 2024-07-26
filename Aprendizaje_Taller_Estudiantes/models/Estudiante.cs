using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendizaje_Taller_Estudiantes.models
{
    public class Estudiante : Persona
    {
        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public List<double> Calificaciones { get; set; } = new List<double>();

        public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocument, string emal, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocument;
            Email = emal;
            Telefono = telefono;
            NombreAcudiente = nombreAcudiente;
            CursoActual = cursoActual;
            FechaNacimiento = fechaNacimiento;
            Calificaciones = new List<double>();
        }

        public override void MostrarDetalle()//sobre escritura de metodos
        {
            base.MostrarDetalle();
            Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
            Console.WriteLine($"Curso Actual: {CursoActual}");
            Console.WriteLine($"Edad: {CalcularEdad()} años");
            MostrarCalificaciones();
            CalcularPromedio();
         
        }

        public void AgregarCalificaciones(double calificacion)
        {
            Calificaciones.Add(calificacion);
            Console.WriteLine("La calificacion de agrego correctamente");
        }
         public string ObtenerNumDocumento(){
            return NumeroDocumento;
         }
        public void MostrarCalificaciones()
        {
            Console.WriteLine($"Calificaciones de {Nombre} {Apellido}");
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine(calificacion);
            }

        }

        private void CalcularPromedio()
        {  

         Console.WriteLine($"El promedio de las calificaciones es de: {Calificaciones.Average()}");
            
        }

        public int CalcularEdad()
        {
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);
            int edad = fechaActual.Year - FechaNacimiento.Year;
            return edad;

        }
        public string ObtenerNombre(){
            return Nombre;
        }

        public static void EditarEstudiante(Estudiante estudiante) 
        // al tener atributos protected, generamos un método para permitir su edición
        {
            if (estudiante != null)
            {
                Console.WriteLine("Nuevo Email: ");
                estudiante.Email = Console.ReadLine();

                Console.WriteLine("Nuevo Teléfono: ");
                estudiante.Telefono = Console.ReadLine();

                Console.WriteLine("Nuevo acudiente: ");
                estudiante.NombreAcudiente = Console.ReadLine();

                Console.WriteLine("Nuevo curso: ");
                estudiante.CursoActual = Console.ReadLine();


            }
        }

    }
}