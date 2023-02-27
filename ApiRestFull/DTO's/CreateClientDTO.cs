using DTO_s;

namespace DTOs
{
    public class CreateClientDTO
    {
        public PersonaDTO persona { get; set; }
        public string? Contraseña { get; set; }
        public bool Estado { get; set; }
    }
}
