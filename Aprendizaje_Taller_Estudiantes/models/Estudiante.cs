using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendizaje_Taller_Estudiantes.models
{
    public class Estudiante : Persona // se hereda persona a estudiante
    {
        public string NombreAcudiente { get; set; }//se definen atributos
        public string CursoActual { get; set; }
        public DateOnly FechaNacimiento { get; set; }
        public List<double> Calificaciones { get; set; } = new List<double>();

        public Estudiante(string nombre, string apellido, string tipoDocumento, string numeroDocument, string emal, string telefono, string nombreAcudiente, string cursoActual, DateOnly fechaNacimiento)
        { //constructor
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

        public void AgregarCalificaciones(double calificacion)// agg calificaciones a la lista
        {
            Calificaciones.Add(calificacion);
            Console.WriteLine("La calificacion de agrego correctamente");
        }
         public string ObtenerNumDocumento(){//retorna ya que algunos atributos son protected, de esta manera se pueden acceder a ellos desde otras clases
            return NumeroDocumento;
         }
        public void MostrarCalificaciones()//muestra la lista de calificaciones con foreach
        {
            Console.WriteLine($"Calificaciones de {Nombre} {Apellido}");
            foreach (var calificacion in Calificaciones)
            {
                Console.WriteLine(calificacion);
            }

        }

        private void CalcularPromedio()
        {  

         Console.WriteLine($"El promedio de las calificaciones es de: {Calificaciones.Average()}");//calcula promedio
            
        }

        public int CalcularEdad()//calcular edad
        {
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now);//resta la fecha actual con la fecha de nacimiento
            int edad = fechaActual.Year - FechaNacimiento.Year;
            return edad;//devuelve la edad

        }
        public string ObtenerNombre(){//retorna ya que algunos atributos son protected, de esta manera se pueden acceder a ellos desde otras clases
            return Nombre;
        }

        public string ObtenerApellido(){
            return Apellido;
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