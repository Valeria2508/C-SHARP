using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Taller.models
{
    public class Propietario
    {
        [Key]
        public int Id { get; set;}
        [MinLength(5, ErrorMessage = "the name field must be at least {1} characters")]
        [MaxLength(125, ErrorMessage = "")]

        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string NumeroDeIdentificacion { get; set; }
        public required string Direccion { get; set; }
        public required string Telefono { get; set;}


        [EmailAddress(ErrorMessage = "")]
        [MinLength(5,ErrorMessage ="")]

        public required string Correo  { get; set; }
    }
}