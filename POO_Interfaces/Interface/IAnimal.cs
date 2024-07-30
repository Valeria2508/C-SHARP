using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Interface
{
    public interface IAnimal
    {
        public void Comer(); // se puede o no poner public
        public void Dormir(); 
        public void Respirar();
        public void Desplazar();

    }
}