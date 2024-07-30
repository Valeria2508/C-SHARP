using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interfaces.Interface;

namespace POO_Interfaces.models
{
    public class Leon : Animal, IAnimal // AL HEREDAR UNA INTERFACE, TODO SE DEBE HEREDAR
    {
        public bool Melena { get; set; }

        public Leon(string nombre, double pesoKg, bool melena) : base(nombre, pesoKg)
        {
            Melena = melena;
        }
//#######   METODOS DE INTERFACE ###
        public void Comer()
        {
            throw new NotImplementedException();
        }

        public void Dormir()
        {
            throw new NotImplementedException();
        }

        public override void Respirar() //TAMBIEN ES METODO DE LA CLASE ABSTRACT ENTONCES SE RECIBE CON OVERRIDE
        {
            throw new NotImplementedException();
        }

        public void Desplazar()
        {
            throw new NotImplementedException();
        }
//####  FIN METODO INTERFACE ####

// primero implemento los metodos obligatorios por la interface y luego pomgo los metodos unicos de la clase
        public void Cazar(){

        }


    }
}