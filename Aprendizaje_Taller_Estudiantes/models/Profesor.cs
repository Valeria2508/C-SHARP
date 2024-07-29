using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendizaje_Taller_Estudiantes.models
{
    public class Profesor : Persona
    {
        //se crean los atributos con sus tipos de variables
        public string Asignatura { get; set; }
        private double Salario { get; set; }
        public DateTime FechaContratacion { get; set; }
        public List<string> Cursos { get; set; } = new List<string>(); // se crea e inicializa unal lista

        //constructor
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
        //metodo mostrar detalle de profesor
        public override void MostrarDetalle()
        {
            base.MostrarDetalle();
            Console.WriteLine($"Asignatura: {Asignatura}"); //imprime en consola
            Console.WriteLine($"Salario: ${Salario} pesos");
            Console.WriteLine($"Fecha de Contratación: {FechaContratacion.ToString()}");
            Console.WriteLine($"El profesor lleva: {CalcularAntiguedad()} meses de antiguedad en el colegio");
            MostrarCursos(); //llamar metodo
        }
        //metodo calcular antiguedad del profesor
        public int CalcularAntiguedad()
        {
            DateTime FechaActual = DateTime.Now;//define la fecha actual
            int antiguedad = (FechaActual.Year - FechaContratacion.Year) * 12 + FechaActual.Month - FechaContratacion.Month; //compara la diferecia de tiempo para sacar la antiguedad del profesor
            return antiguedad; //devuelve la variable
        }
        //metodo agregar cursos
        public void AgregarCursos(string curso)
        {
            Cursos.Add(curso);//se adicionan los cursos a la lista
            Console.WriteLine("El curso de agrego correctamente");
        }
        //muestra los cursos con un foreach
        public void MostrarCursos()
        {
            Console.WriteLine($"Los cursos que brinda el profesor {Nombre} son");
            foreach (var curso in Cursos)
            {
                Console.WriteLine(curso);
            }

        }
        //retorna ya que algunos atributos son protected, de esta manera se pueden acceder a ellos desde otras clases
        public string ObtenerNumDocumento()
        {
            return NumeroDocumento;
        }
        //retorna ya que algunos atributos son protected, de esta manera se pueden acceder a ellos desde otras clases
        public string ObtenerNombre(){
            return Nombre;
        }

        public double ObtenerSalario()
        {
            Console.WriteLine($"El salario en pesos colombianos es de: ${Salario}pesos");//se obtiene el salario
            return this.Salario;
        }

        public static void EditarProfesor(Profesor profesor){ //metodo para editar los datos de un profesor
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