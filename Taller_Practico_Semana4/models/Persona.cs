using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_Semana4.models
{
    public class Persona
    {   // creo los atributos
        protected Guid Id { get; set; }
        protected string Nombre {get; set; }
        protected string Apellido { get; set; }
        protected string TipoDocumento { get; set; }
        protected string NumeroDocumento { get; set; }
        protected string Email { get; set; }
        protected string Telefono { get; set; }

        //Metodo mostrar detalles de la persona
        public virtual void MostrarDetalles(){
            Console.WriteLine($@" 
            Nombre: {Nombre}
            Apellido: {Apellido}
            Tipo Documento: {TipoDocumento}
            Numero Documento: {NumeroDocumento}
            Email: {Email}
            Telefono: {Telefono}");
        }
    }
}