using DTOs;

namespace UsesCases
{
    public interface ICreateClientInputPort
    {
        Task Handler(CreateClientDTO cliente);
    }
}
