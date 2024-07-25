using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller_Practico_POO.models
{
    public class Tienda:Prenda
    {

        //crear e iniciar lista
        public List<Tienda> Prendas { get; set; } = new List<Tienda>();

        public void AggPrenda(Tienda prenda)
        {
            Prendas.Add(prenda);
            Console.WriteLine("La prenda ha sido agregada correctamente");
        }
    }
}