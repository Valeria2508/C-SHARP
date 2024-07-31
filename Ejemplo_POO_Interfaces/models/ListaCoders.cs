using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplo_POO_Interfaces.Interface;

namespace Ejemplo_POO_Interfaces.models
{
    public class ListaCoders : Coder, ICoder
    {
        public  List<Coder> Coders { get; set; } = new List<Coder>();

        public ListaCoders(string nombre, string apellido, int edad, string clan) : base(nombre, apellido, edad, clan)
        {

        }

        public static void Menu()
        {
            bool bandera = true;
            while (bandera)
            {
                Console.WriteLine("1. Agregar coder");
                Console.WriteLine("2. Editar coders");
                Console.WriteLine("2. Eliminar coders");
                Console.WriteLine("2. Mostrar coders");
                Console.WriteLine("0. Salir");

                var opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "0":

                        bandera=false;
                        break;

                    case "1":
                        Console.WriteLine("Ingrese nombre: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese Apellido: ");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese Edad: ");
                        int edad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese Clan: ");
                        string clan = Console.ReadLine();

                        var coder1 = new Coder(nombre, apellido, edad, clan);
                        Crear(coder1);
                        break;
                    case "2":
                        Console.WriteLine("Ingrese el nombre del coder a editar: ");
                        string nuevoBuscar = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del coder a editar: ");
                        string nuevoApellido = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad del coder a editar: ");
                        int nuevaEdad = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el clan del coder a editar: ");
                        string nuevoClan = Console.ReadLine();


                        break;




                    
                }

            }


        }

        public void Crear(Coder coder)
        {
            Coders.Add(coder);
            Console.WriteLine("El coder se agrego con éxito");
        }

        public void Editar()
        {
            throw new NotImplementedException();
        }

        public void Eliminar()
        {
            throw new NotImplementedException();
        }

        public void Mostrar(Coder coder)
        {
            foreach (var i in Coders)
            {
                
            }
        }

        public void PausarMenu()
        {
            Console.WriteLine("Presiona una tecla para continuar");
            Console.ReadKey();
        }


    }
}