using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Crud_Docente.Models
{
    public class Docente
    {
        [Key]
        [Column("id")]
        public string Id { get; set; }

        [Column("nombre")]
        [MaxLength(40,ErrorMessage ="no es valido digitar mas de 40 caracteres")]
        [MinLength(2, ErrorMessage ="debes digitar al menos 2 caracter")]
        public string Nombre { get; set; }  

        [Column("apellido")]
        [MaxLength(50, ErrorMessage ="no es valido digitar mas de 40 caracteres")]
        [MinLength(4, ErrorMessage ="debes digitar al menos 4 caracter")]
        public string Apellido { get; set; }

        [Column("tipo_documento")]
        [MaxLength(20, ErrorMessage ="documento no valido")]
        public string Tipo_documento { get; set;}

        [Column("numero_documento")]
        [Range(1,20, ErrorMessage ="numero de documento no valido")]
        public int Numero_documento { get; set; }

        [Column("fecha_nacimiento")] 
        public DateTime Fecha_nacimiento { get; set; }

        [Column("genero")]
        public string Genero { get; set; }

        [Column("materias")]
        public string Materias { get; set; }

        [Column("titulacion_academica")]
        public string Titulacion_academica { get; set; }

        [Column("anios_experiencia")]
        public int Anios_experiencia { get; set; }
    }
}