using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace RuletaMasivian.Models
{
    public class Ruletas
    {
        [Key]
        public int id { get; set; }
        public string estado { get; set; }
    }
}
