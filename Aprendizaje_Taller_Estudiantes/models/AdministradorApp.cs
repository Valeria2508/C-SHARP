using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Aprendizaje_Taller_Estudiantes.models
{
    public class AdministradorApp
    {
        public static List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();//se crean e inicializan listas
        public static List<Profesor> Profesores { get; set; } = new List<Profesor>();

        public static void MostrarLinq()//se crea el menu de los linq
        {
            var bandera = true;
            while (bandera)
            {
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                               Busquedas LINQ                                            ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("                             1. Filtrar por promedio > 85                                ");
                Console.WriteLine("                             2. Profesores con más de un curso                           ");
                Console.WriteLine("                             3. Estudiantes mayores a 16 años                            ");
                Console.WriteLine("                             4. Ordenar estudiantes por apellido asc                     ");
                Console.WriteLine("                             5. Salario de todos los profesores                          ");
                Console.WriteLine("                             6. Calificación más alta                                    ");
                Console.WriteLine("                             7. Cantidad de estudiantes por curso                        ");
                Console.WriteLine("                             8. Profesores con más de 10 años                            ");
                Console.WriteLine("                             9. Obtener asignaturas únicas                               ");
                Console.WriteLine("                            10. Estudiantes con acudiente llamada María                  ");
                Console.WriteLine("                            11. Ordenar profesores por salario desc                      ");
                Console.WriteLine("                            12. Promedio de edad de estudiantes                          ");
                Console.WriteLine("                            13. Profesores de Matemáticas                                ");
                Console.WriteLine("                            14. Estudiantes con más de 3 calificaciones registradas.     ");
                Console.WriteLine("                            15. Promedio de antigüedad de todos los profesores.                    ");
                Console.WriteLine("                             0. Salir                                                    ");
                Console.WriteLine("=========================================================================================");
                Console.WriteLine("Selecciona una opción: ");

                var opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "0":
                        bandera = false;
                        break;
                    case "1":
                        var promedioMayor85 = Estudiantes.Where(estudiante => estudiante.Calificaciones.Average() > 85).ToList();
                        Console.WriteLine($"Estudiantes con promedio mayor a 85: ");
                        MostrarEstudiantes(promedioMayor85);
                        PausarMenu();
                        break;
                    case "2":
                        var profesoresMasDeUnCurso = Profesores.Where(p => p.Cursos.Count > 1).ToList();
                        Console.WriteLine($"Profesores con más de un curso: ");
                        MostrarProfesores(profesoresMasDeUnCurso);
                        break;
                    case "3":
                        var edadMayor16 = Estudiantes.Where(estudiante => estudiante.CalcularEdad() > 16).ToList();
                        Console.WriteLine($"Estudiantes con edad mayor a 16: ");
                        MostrarEstudiantes(edadMayor16);
                        PausarMenu();
                        break;
                    case "4":
                        var estudiantesOrdenados = Estudiantes.OrderBy(estudiante => estudiante.ObtenerApellido()).ToList();
                        MostrarEstudiantes(estudiantesOrdenados);
                        PausarMenu();
                        break;
                    case "5":
                        var totalSalario = Profesores.Sum(profesor => profesor.ObtenerSalario());
                        Console.WriteLine($"El salario total de los profesores es: {totalSalario:C} COP");
                        PausarMenu();
                        break;
                    case "6":
                        Console.WriteLine("Error en el sistema!");
                        PausarMenu();
                        break;
                    case "7":
                        Console.WriteLine("Error en el sistema!");
                        PausarMenu();
                        break;
                    case "8":
                        var profesoresMas10años = Profesores.Where(profesor => profesor.CalcularAntiguedad() > (10 * 12)).ToList();
                        Console.WriteLine($"Profesores con más de 10 años de antiguedad: ");
                        MostrarProfesores(profesoresMas10años);
                        PausarMenu();
                        break;
                    case "9":
                        Console.WriteLine("Error en el sistema!");
                        PausarMenu();
                        break;
                    case "10":
                        var estudiantesAcudienteMaria = Estudiantes.Where(estudiante => estudiante.NombreAcudiente.Contains("María")).ToList();
                        Console.WriteLine($"Estudiantes con promedio mayor a 85: ");
                        MostrarEstudiantes(estudiantesAcudienteMaria);
                        PausarMenu();
                        break;
                    case "11":
                        var profesoresOrdenadosSalario = Profesores.OrderByDescending(profesor => profesor.ObtenerSalario()).ToList();
                        Console.WriteLine($"Profesores ordenados según su salario (desc): ");
                        MostrarProfesores(profesoresOrdenadosSalario);
                        PausarMenu();
                        break;
                    case "12":
                        var promedioEdad = Estudiantes.Average(estudiante => estudiante.CalcularEdad());
                        Console.WriteLine($"La edad promedio de los estudiantes es de {promedioEdad} años");
                        PausarMenu();
                        break;
                     case "13":
                        var profesoresMatematicas = Profesores.Where(profesor => profesor.Asignatura == "Matemáticas").ToList();
                        Console.WriteLine($"Profesores que enseñan matemáticas: ");
                        MostrarProfesores(profesoresMatematicas);
                        PausarMenu();
                        break;
                     case "14":
                        var estudiantesMas3Calificaciones = Estudiantes.Where(estudiante => estudiante.Calificaciones.Count > 3).ToList();
                        Console.WriteLine($"Estudiantes con más de 3 calificaciones registrados: ");
                        MostrarEstudiantes(estudiantesMas3Calificaciones);
                        PausarMenu();
                        break;
                     case "15":
                        var promedioAntiguedad = Profesores.Average(profesor => profesor.CalcularAntiguedad());
                        Console.WriteLine($"El rpmedio de antiguedad de los profesores es de {promedioAntiguedad} meses");
                        PausarMenu();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, intenta nuevamente");
                        break;
                    
                }
            }
        }

        public static void Menu()//se crea el menu para navegar en el sistema escolar
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
                        MostrarEstudiantes(Estudiantes);//se llama metodo
                        break;
                    case "4":
                        MostrarProfesores(Profesores);//se llama metodo
                        break;
                    case "5":
                        EditarEstudiante();//se llama metodo
                        break;
                    case "6":
                        EditarProfesor();//se llama metodo

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
                        MostrarLinq();
                        break;
                    case "10":
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

        public static void MostrarEstudiantes(List<Estudiante> estudiantes)
        {
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarDetalle();
            }
        }

        public static void MostrarProfesores(List<Profesor> profesores)
        {
            foreach (var profesor in profesores)
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


        public static void AgregarEstudiantes() // Datos quemados de ejemplo.
        {
            var estudiante1 = new Estudiante("Ana", "Fernández", "CC", "55443322", "ana.fernandez@example.com", "555-6789", "Jorge Fernández", "once", new DateOnly(2004, 7, 22));
            var estudiante2 = new Estudiante("Miguel", "Torres", "TI", "22334455", "miguel.torres@example.com", "555-4321", "Rosa Torres", "décimo", new DateOnly(2006, 4, 17));
            var estudiante3 = new Estudiante("Laura", "Sánchez", "CC", "66778899", "laura.sanchez@example.com", "555-8765", "Pablo Sánchez", "noveno", new DateOnly(2007, 9, 10));
            var estudiante4 = new Estudiante("Jorge", "Hernández", "TI", "33445566", "jorge.hernandez@example.com", "555-5432", "Luz Hernández", "octavo", new DateOnly(2008, 12, 3));
            var estudiante5 = new Estudiante("Sara", "Ramírez", "CC", "88990011", "sara.ramirez@example.com", "555-2109", "Manuel Ramírez", "décimo", new DateOnly(2006, 2, 15));

            Estudiantes.Add(estudiante1);
            Estudiantes.Add(estudiante2);
            Estudiantes.Add(estudiante3);
            Estudiantes.Add(estudiante4);
            Estudiantes.Add(estudiante5);

            estudiante1.AgregarCalificaciones(80);
            estudiante1.AgregarCalificaciones(65);

            estudiante2.AgregarCalificaciones(95);
            estudiante2.AgregarCalificaciones(35);

            estudiante3.AgregarCalificaciones(85);
            estudiante3.AgregarCalificaciones(100);

            estudiante4.AgregarCalificaciones(100);
            estudiante4.AgregarCalificaciones(90);

            estudiante5.AgregarCalificaciones(95);
            estudiante5.AgregarCalificaciones(70);

        }

        public static void AgregarProfesoresEj() // Datos quemados de ejemplo
        {
            var profesor1 = new Profesor("Laura", "González", "CC", "123456789", "laura.gonzalez@example.com", "555-1111", "Matemáticas", 8000000, new DateTime(2015, 9, 1));
            var profesor2 = new Profesor("Jorge", "Martínez", "TI", "987654321", "jorge.martinez@example.com", "555-2222", "Historia", 8200000, new DateTime(2016, 3, 15));
            var profesor3 = new Profesor("Ana", "Rodríguez", "CC", "456123789", "ana.rodriguez@example.com", "555-3333", "Biología", 8500000, new DateTime(2017, 1, 10));

            Profesores.Add(profesor1);
            Profesores.Add(profesor2);
            Profesores.Add(profesor3);

            profesor1.AgregarCursos("sexto");
            profesor1.AgregarCursos("séptimo");
            profesor2.AgregarCursos("octavo");
            profesor2.AgregarCursos("décimo");
            profesor3.AgregarCursos("once");
            profesor3.AgregarCursos("noveno");
        }
    

    public static void PausarMenu() // generamos una pausa en el menú para mejorar la experiencia de usuario
    {
        Console.WriteLine("Presiona una tecla para continuar");
        Console.ReadKey();
    }
    }


}