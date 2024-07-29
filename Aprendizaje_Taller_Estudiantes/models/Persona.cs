using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aprendizaje_Taller_Estudiantes.models
{
    public class Persona
    {
        protected Guid Id {get;set;} // guis para id automatico
        protected string Nombre {get; set;}//se crean atributos
        protected string Apellido {get; set;}
        protected string TipoDocumento {get; set;}
        protected string NumeroDocumento {get; set;}
        protected string Email {get; set;}
        protected string Telefono {get; set;}

        public virtual void MostrarDetalle(){ //se mustran los detalles de las personas
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Apellido: {Apellido}");
            Console.WriteLine($"Tipo de Documento: {TipoDocumento}");
            Console.WriteLine($"Número de Documento: {NumeroDocumento}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Teléfono: {Telefono}");
    
        }
    }
}