using Entities;

namespace DTO_s
{
    public class ClienteDTO
    {
        public string? Contraseña { get; set; }
        public bool Estado { get; set; }
        public string Nombre { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public int Identificacion { get; set; }
        public string Direccion { get; set; }
        public long? Telefono { get; set; }
    }
    public class ClienteOutDTO
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public long? Telefono { get; set; }
        public bool Estado { get; set; }
    }
}
