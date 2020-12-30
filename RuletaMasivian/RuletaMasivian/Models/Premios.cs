using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RuletaMasivian.Models
{
    public class Premios
    {
        [Key]
        public int id { get; set; }
        public int idapuesta { get; set; }
        public int idruleta { get; set; }
        public int idusuario { get; set; }
        public string tipoapuesta { get; set; }
        public int valorapuesta { get; set; }
        public int valorpremio { get; set; }
    }
}
