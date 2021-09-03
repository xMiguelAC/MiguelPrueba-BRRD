using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MiguelPrueba.Models
{
    [Table("Persona")]
    public class Persona
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [MaxLength(40, ErrorMessage = "Máximo 40 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaDeNacimiento { get; set; }

        public Persona()
        {

        }
    }
}
