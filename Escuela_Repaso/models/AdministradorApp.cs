using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Repaso.models
{
    public class AdministradorApp
    {
        // TODOS LOS METODOS SON ESTATICOS
        // SE CREAN DOS LISTAS ESTATICAS
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public static List<Profesor> Profesores = new List<Profesor>();

        // METODOS PARA AGREGAR Y MOSTRAR LAS LISTAS QUE  SE CREARON ANTERIORMENTE

        public static void AgregarEstudiante(Estudiante estudiante){
            Estudiantes.Add(estudiante);
            Console.WriteLine("El estuduante se agrego con exito");
        }

        public static void AgregarProfesor(Profesor profesor){
            Profesores.Add(profesor);
            Console.WriteLine("El profesor se agrego con exito");
        }

 
    }
}