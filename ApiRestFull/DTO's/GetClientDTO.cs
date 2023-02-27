using DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class GetClientDTO
    {
        public PersonaDTO persona { get; set; }
        public string? Contraseña { get; set; }
        public bool Estado { get; set; }
    }
}
