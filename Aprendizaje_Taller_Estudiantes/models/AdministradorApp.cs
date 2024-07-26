using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Aprendizaje_Taller_Estudiantes.models
{
    public class AdministradorApp
    {
        public static List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();
        public static List<Profesor> Profesores { get; set; } = new List<Profesor>();

        public static void Menu()
        {

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("################################");
                Console.WriteLine("###      Sistema Escolar     ###");
                Console.WriteLine("################################");
                Console.WriteLine(".");
                Console.WriteLine("################################");
                Console.WriteLine("#       1. Agregar estudiante   #");
                Console.WriteLine("#       2. Agregar profesores   #");
                Console.WriteLine("#       3. Mostrar estudiante   #");
                Console.WriteLine("#       4. Mostrar Profesores   #");
                Console.WriteLine("#       5. Editar estudiantes   #");
                Console.WriteLine("#       6. Editar profesores    #");
                Console.WriteLine("#       7. Eliminar estudiantes #");
                Console.WriteLine("#       8. Eliminar profesores  #");
                Console.WriteLine("#       9. Salir                #");
                Console.WriteLine("################################");

                Console.WriteLine("Ingrese su opcion: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el nombre");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese el tipo de documento");
                        string tipoDocumento = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de documento");
                        string numeroDocumento = Console.ReadLine();
                        Console.WriteLine("Ingrese el email");
                        string email = Console.ReadLine();
                        Console.WriteLine("Ingrese telefono");
                        string telefono = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre del acudiente");
                        string nombreAcudiente = Console.ReadLine();
                        Console.WriteLine("Ingrese el curso actual");
                        string cursoActual = Console.ReadLine();
                        Console.WriteLine("Ingrese fecha de nacimiento");
                        DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                        DateOnly fechaNacido = DateOnly.FromDateTime(fechaNacimiento);

                        //intanciar objeto para agg todo
                        var estudiante1 = new Estudiante(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, nombreAcudiente, cursoActual, fechaNacido);
                        AgregarEstudiante(estudiante1);
                        PedirCalificaciones(estudiante1);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre");
                        string nombreProfesor = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido");
                        string apellidoProfesor = Console.ReadLine();
                        Console.WriteLine("Ingrese el Tipo de documento");
                        string tipoDocumentoProfesor = Console.ReadLine();
                        Console.WriteLine("Ingrese el numero de documento");
                        string numeroDocumentoProfesor = Console.ReadLine();
                        Console.WriteLine("Ingrese el email");
                        string emailProfesor = Console.ReadLine();
                        Console.WriteLine("Ingrese el telefono");
                        string telefonoProfesor = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre de la asignatura");
                        string asignatura = Console.ReadLine();
                        Console.WriteLine("Ingrese el salario mensual");
                        double salarioMensual = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Ingrese la fecha de contratacio (dia/mes/año))");
                        DateTime FechaContratacion = Convert.ToDateTime(Console.ReadLine());

                        //intanciar objeto para agregar todo
                        var profe1 = new Profesor(nombreProfesor, apellidoProfesor, tipoDocumentoProfesor, numeroDocumentoProfesor, emailProfesor, telefonoProfesor, asignatura, salarioMensual, FechaContratacion);
                        AgregarProfesor(profe1);
                        PedirCursos(profe1);
                        break;
                    case "3":
                        MostrarEstudiantes();
                        break;
                    case "4":
                        MostrarProfesores();
                        break;
                    case "5":
                        EditarEstudiante();
                        break;
                    case "6":
                        EditarProfesor();

                        break;
                    case "7":
                        var estudiante = BuscarEstudiante();
                        EliminarEstudiante(estudiante);
                        break;
                    case "8":
                        var profesor = BuscarProfesor();
                        EliminarProfesor(profesor);
                        break;
                    case "9":
                        salir = true;
                        break;


                }
                if (!salir)
                {
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();//espera que el usuario presione una tecla para continuar
                    Console.Clear();
                }
            }



        }

        public static void AgregarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
            Console.WriteLine("El estudiante ha sido agregado exitosamente");
        }
        public static Estudiante BuscarEstudiante() // buscamos un estudiante específico para editar o eliminar
        {
            Console.WriteLine("Ingresa el número de documento del estudiante: ");
            var numDocumento = Console.ReadLine();
            return Estudiantes.Find(estudiante => estudiante.ObtenerNumDocumento() == numDocumento);
        }
        public static Profesor BuscarProfesor()
        {
            Console.WriteLine("Ingresa el número de documento del estudiante: ");
            var numDocumento = Console.ReadLine();
            return Profesores.Find(profe => profe.ObtenerNumDocumento() == numDocumento);
        }



        public static void AgregarProfesor(Profesor profesor)
        {
            Profesores.Add(profesor);
            Console.WriteLine("El profesor ha sido agregado exitosamente");
        }

        public static void PedirCalificaciones(Estudiante estudiante)
        {
            Console.WriteLine("Cuantas calificaciones desea ingresar?");
            int cantidadNotas = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= cantidadNotas; i++)
            {
                Console.WriteLine($"Ingrese la {i} nota");
                var nota = Convert.ToDouble(Console.ReadLine());
                estudiante.AgregarCalificaciones(nota);
            }
        }

         public static void PedirCursos(Profesor profesor)
        {
            Console.WriteLine("Cuales cursos desea ingresar?");
            int cantidadCursos = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= cantidadCursos; i++)
            {
                Console.WriteLine($"Ingrese el curso");
                var curso = Console.ReadLine();
                profesor.AgregarCursos(curso);
            }
        }

        public static void MostrarEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalle();
            }
        }

        public static void MostrarProfesores()
        {
            foreach (var profesor in Profesores)
            {
                profesor.MostrarDetalle();
            }
        }

        public static void EliminarEstudiante(Estudiante estudiante)
        {
            Estudiantes.Remove(estudiante);
            Console.WriteLine("El estudiante ha sido eliminado exitosamente.");

        }

        public static void EliminarProfesor(Profesor profesor)
        {
            Profesores.Remove(profesor);
            Console.WriteLine("El estudiante ha sido eliminado exitosamente.");

        }

         public static void EditarEstudiante()
        {
            var estudianteEncontrado = BuscarEstudiante();
            Estudiante.EditarEstudiante(estudianteEncontrado);
            Console.WriteLine($"El estudiante {estudianteEncontrado.ObtenerNombre()} fue editado satisfactoriamente");
        }

        
        public static void EditarProfesor()
        {
            var profesorEncontrado = BuscarProfesor();
            Profesor.EditarProfesor(profesorEncontrado);
            Console.WriteLine($"El profesor {profesorEncontrado.ObtenerNombre()} fue editado satisfactoriamente");
        }
    }
}