using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_Semana4.models
{   //se crean atrbutos
    public class Profesor:Persona
    {
        public string Asignatura { get; set;}
        private double Salario {get; set;}
        public DateTime FechaContratacion {get; set;}
        public List<string> Cursos {get; set;}
        //contructor
        public Profesor(string nombre, string apellido, string tipoDocumento, string numeroDocumento, string email, string telefono,string asignatura, double salario, DateTime fechaContratacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            Email = email;
            Telefono = telefono;
            Asignatura = asignatura;
            Salario = salario;
            FechaContratacion = fechaContratacion;
            Cursos = new List<string>();
        }

        //metodos
        public int CalcularAntiguedad(){
            return 0;
        }

        public void ObtenerSalario(){

        }


    }
}