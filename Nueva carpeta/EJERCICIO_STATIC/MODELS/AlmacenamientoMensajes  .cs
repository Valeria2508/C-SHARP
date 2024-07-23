using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EJERCICIO_STATIC.MODELS
{
    public class AlmacenamientoMensajes  
    {

        public static List<string> Mensajes { get; set; } = new List<string>();//se crea y se inicializa la lista

        // metodo vacio que recibe un parametro
        public static void AgregarMensaje(string mensaje)
        {   //se agrega a la lista Mensajes
            Mensajes.Add(mensaje);
        }

        

        public static void MostrarMensaje(){
           foreach (var mensaje in Mensajes)
           {
            Console.WriteLine("el mensaje es: "+mensaje);
           }
        } 
    }
}