using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Repaso.models
{   //  ESTUDIANTE HEREDA DE PERSONA
    public class Estudiante: Persona 
    {
        //  ATRIBUTOS PUBLICOS, SE USAN EN CUALQUIR PARTE

        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set; }
        public DateOnly FechaNacimiento { get; set;}

        //  SE CREA Y SE INICIALIZA LA LISTA
        public List<double> Calificaciones = new List<double>();

        //  CONSTRUCTOS YA QUE VAMOS A CREAR ESTUDIANTES Y VAMOS A HEREDAR ATRIBUTOS DE PERSONAS
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
        }

        // YA CREE EL CONSTRUCTO, SIGUEN LOS METODOS PLANTEADOS

        // EL METODO SE CREO void YA QUE VA A IMPRIMIR ALGO Y RECIBE CALIFICACION YA QUE EL USUARIO SE LA VA A DAR PARA QUE LA FUNCION LA AGREGUE A LA LISTA
        public void AgregarCalificacion(double calificacion){
            Calificaciones.Add(calificacion);
            Console.WriteLine("La calificacion se agrego correctamente");
        }

        private void CalcularPromedio(){
            double Suma = Calificaciones.Sum();
            Suma = Calificaciones.Average();
            Console.WriteLine($"El promedio de las notas es de {CalcularPromedio}");

        }
    }
}