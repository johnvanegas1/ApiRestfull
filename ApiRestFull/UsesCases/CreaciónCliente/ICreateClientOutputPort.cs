using DTO_s;

namespace UsesCases.CreaciónUsuario
{
    public interface ICreateClientOutputPort
    {
        Task Handler(ClienteOutDTO cliente);
    }
}
