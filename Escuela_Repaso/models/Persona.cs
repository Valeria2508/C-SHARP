using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Escuela_Repaso.models
{
    public class Persona
    {   //   METODOS PROTEGIDOS, SOLO SE USA EN ESTA CLASE A NO SER DE QUE SE HEREDE O SE CONVIERTA EN PUBLICO 
        protected Guid Id { get; set; }
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string TipoDocumento { get; set; }
        protected string NumeroDocumento { get; set; }
        protected string Email { get; set; }
        protected string Telefono { get; set; }


        //  METODO PARA MOSTRAR DETALLES DE LA PERSONA ESTE ES EL PADRE

        public void MostrarDetalles(){
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Tipo de documeto: {TipoDocumento}");
            Console.WriteLine($"Número de documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Teléfono: {Telefono}");
        }

    }
}