using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuarios
    {
        [Key]
        public int IdUsuarios { get; set; }
        public string  NombresUsuarios { get; set; }
        public string Nombres { get; set; }
        public string Contrasena { get; set; }
        public DateTime Fecha { get; set; }
        
    }
}
