using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_Semana4.models
{
    public class AdministradorApp
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public static List<Profesor> Profesores = new List<Profesor>();


        public static void Menu()
        {
            bool salir = false;
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1. Agregar Estudiante");
            Console.WriteLine("2. Mostrar Estudiantes");
            Console.WriteLine("3. Agregar Profesor");
            Console.WriteLine("4. Mostrar Profesores");
            Console.WriteLine("Salir del programa");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingresa el nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa el apellido");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingresa el Tipo de documento");
                    string tipoDocumento = Console.ReadLine();
                    Console.WriteLine("Ingresa el Numero de documento");
                    string numeroDocumento = Console.ReadLine();
                    Console.WriteLine("Ingresa el Email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Ingresa el Telefono");
                    string telefono = Console.ReadLine();
                    Console.WriteLine("Ingresa el Nombre del Acudiente");
                    string NombreAcudiente = Console.ReadLine();
                    Console.WriteLine("Ingresa el curso actual del estudiante");
                    string cursoActual = Console.ReadLine();
                    
                    Console.WriteLine("Ingresa la fecha de nacimiento del estudiante");
                    DateTime fechaNacimiento = Convert.ToDateTime(Console.ReadLine());
                    DateOnly fechaNacido = DateOnly.FromDateTime(fechaNacimiento);
                    Console.WriteLine("Ingresa las calificaciones del estudiante");
                    double calificaciones = Convert.ToDouble(Console.ReadLine());
                    var estudiante1 = new Estudiante(nombre,apellido,tipoDocumento,numeroDocumento,email,telefono,NombreAcudiente,cursoActual,fechaNacido );
                    AgregarEstudiante(estudiante1);
                    break;
                case "2":
                    MostrarEstudiantes();
                    break;
                case "3":
                    
                    break;


            }
        }

        public static void AgregarEstudiante(Estudiante estudiante)
        {


            Estudiantes.Add(estudiante);
        }


        public static void AgregarProfesor(Profesor profesor)
        {
        }

        public static void MostrarEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarDetalles();
            }

        }
        public static void MostrarProfesores()
        {
        }
    }
}