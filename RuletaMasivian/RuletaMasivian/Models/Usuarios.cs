using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace RuletaMasivian.Models
{
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public long credito { get; set; }
    }
}
