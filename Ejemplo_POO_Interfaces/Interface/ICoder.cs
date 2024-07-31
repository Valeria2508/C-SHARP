using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejemplo_POO_Interfaces.models;

namespace Ejemplo_POO_Interfaces.Interface
{
    public interface ICoder
    {
        public void Crear(Coder coder);
        public void Mostrar();
        public void Editar();
        public void Eliminar();
        public void PausarMenu();
    }
}