using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public int Identificacion { get; set; }
        public string Direccion { get; set; }
        public long? Telefono { get; set; }
    }
}
