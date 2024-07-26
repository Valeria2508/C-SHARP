using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendizaje_Taller_Estudiantes.models
{
    public class Profesor : Persona
    {
        public string Asignatura { get; set; }
        private double Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        public List<string> Cursos { get; set; } = new List<string>();

        public Profesor(string nombre, string apellido, string tipoDocumento, string numeroDocument, string emal, string telefono, string asignatura, double salario, DateTime fechaContratacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocument;
            Email = emal;
            Telefono = telefono;
            Asignatura = asignatura;
            Salario = salario;
            FechaContratacion = fechaContratacion;
            Cursos = new List<string>();
        }

        public override void MostrarDetalle()
        {
            base.MostrarDetalle();
            Console.WriteLine($"Asignatura: {Asignatura}");
            Console.WriteLine($"Salario: ${Salario} pesos");
            Console.WriteLine($"Fecha de Contratación: {FechaContratacion.ToString()}");
            Console.WriteLine($"El profesor lleva: {CalcularAntiguedad()} meses de antiguedad en el colegio");
            MostrarCursos();
        }

        public int CalcularAntiguedad()
        {
            DateTime FechaActual = DateTime.Now;
            int antiguedad = (FechaActual.Year - FechaContratacion.Year) * 12 + FechaActual.Month - FechaContratacion.Month;
            return antiguedad;
        }

        public void AgregarCursos(string curso)
        {
            Cursos.Add(curso);
            Console.WriteLine("El curso de agrego correctamente");
        }

        public void MostrarCursos()
        {
            Console.WriteLine($"Los cursos que brinda el profesor {Nombre} son");
            foreach (var curso in Cursos)
            {
                Console.WriteLine(curso);
            }

        }

        public string ObtenerNumDocumento()
        {
            return NumeroDocumento;
        }

        public string ObtenerNombre(){
            return Nombre;
        }

        public void ObtenerSalario()
        {
            Console.WriteLine($"El salario en pesos colombianos es de: ${Salario}pesos");
        }

        public static void EditarProfesor(Profesor profesor){
            if (profesor!=null)
            {
                Console.WriteLine("Nuevo Email: ");
                profesor.Email = Console.ReadLine();

                Console.WriteLine("Nuevo Teléfono: ");
                profesor.Telefono = Console.ReadLine();

                Console.WriteLine("Nueva Asignatura: ");
                profesor.Asignatura = Console.ReadLine();

            
            }

        }

    
    }
}