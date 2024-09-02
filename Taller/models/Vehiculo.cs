using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }
        public required  string Marca { get; set; }
        public required string Modelo { get; set; }
        public required int PropietarioId { get; set; }
        public required int Año { get; set; }
        public required string Color { get; set; }
        public required string TipoVehiculo { get; set; }

        //enlaces foraneos
        [ForiginKey("PropietarioId")]
        public required Propietario? Propietario { get; set; }
    }
}
|   