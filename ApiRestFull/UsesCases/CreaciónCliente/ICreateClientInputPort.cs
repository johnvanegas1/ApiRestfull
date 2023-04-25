using DTO_s;

namespace UsesCases.CreaciónUsuario
{
    public interface ICreateClientInputPort
    {
        Task Handler(ClienteDTO cliente);
    }
}
