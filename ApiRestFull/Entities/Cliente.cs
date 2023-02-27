using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente : Persona
    {
        public int ClienteId { get; set; }
        public string? Contraseña { get; set; }
        public bool Estado { get; set; }
    }
}
