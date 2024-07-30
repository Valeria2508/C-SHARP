using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Repaso.models
{   //  ESTUDIANTE HEREDA DE PERSONA
    public class Estudiante : Persona
    {
        //  ATRIBUTOS PUBLICOS, SE USAN EN CUALQUIR PARTE

        public string NombreAcudiente { get; set; }
        public string CursoActual { get; set; }
        public DateOnly FechaNacimiento { get; set; }

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
            Calificaciones = new List<double>();
        }

        // YA CREE EL CONSTRUCTO, SIGUEN LOS METODOS PLANTEADOS

        // EL METODO SE CREO void YA QUE VA A IMPRIMIR ALGO Y RECIBE CALIFICACION YA QUE EL USUARIO SE LA VA A DAR PARA QUE LA FUNCION LA AGREGUE A LA LISTA
        public void AgregarCalificacion(double calificacion)
        {
            Calificaciones.Add(calificacion);
            Console.WriteLine("La calificacion se agrego correctamente");
        }

        //  COMO EL METODO ES void SOLO IMPRIME, REALIZA EL METODO PERO IMPRIMIENDOLO EN CONSOLA

        //  Y AL SER EL METODO PRIVADO QUIERE DECIR QUE SOLO SE VA A USAR EN ESTA CLASE
        private void CalcularPromedio()
        {
            Console.WriteLine($"El promediode las calificaciones es de: {Calificaciones.Average()}");
        }

        // METODO ENTERO, RETORNA ALGO SI O SI 
        public int CalcularEdad()
        {
            DateOnly fechaActual = DateOnly.FromDateTime(DateTime.Now); // aqui se calcula la fecha actual
            int edad = fechaActual.Year - FechaNacimiento.Year;// aqui se resta la fecha actual con la fecha de nacimiento que la puso el usuario
            return edad;
        }

        //###################  HASTA AQUI LLEGARON LOS METODS DE ESTUDIANTES PLANTEADOS EN EL UML ###################

        //METODOS ADICIONALES PARA QUE FUNCIONE EL PROGRAMA

        // SE HACE SOBRE ESCRITURA DE METODOS EN MOSTRAR DETALLES
        // 1, EL METODO SE DEBE LLAMAR IGUAL QUE EL METODO DEL PADRE
        //2, EN EL HIJO VA EN OVERRIDE Y EN EL PADRE EL VIRTUAL
        //3, EN EL HIJO VA BASE.NOMBREDELMETODO();
        public override void MostrarDetalles(){
            base.MostrarDetalles();

        }
    }
}