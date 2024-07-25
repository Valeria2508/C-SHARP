using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.models
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Matricula { get; set; }

        //crear lista y se inicializa
        public static List<Estudiante> Estudiantes { get; set; } = new List<Estudiante>();

        //constructor del estudiante
        public Estudiante(string nombre, int edad, string matricula)
        {
            Nombre = nombre;
            Edad = edad;
            Matricula = matricula;
        }
        //metodo agg
        public static void AgregarEstudiantes(Estudiante estudiante)
        {
            Estudiantes.Add(estudiante);
            Console.WriteLine("Estudiante agregado correctamente");
        }
        //metodo mostrar
        public static void MostrarEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                Console.WriteLine($@"
                El estudiante agregado fue: 
                {estudiante.Nombre} 
                {estudiante.Edad} años y su matricula 
                {estudiante.Matricula}");
            }
        }


    }
}