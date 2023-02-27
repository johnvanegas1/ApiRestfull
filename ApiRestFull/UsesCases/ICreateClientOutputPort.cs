using DTOs;

namespace UsesCases
{
    public interface ICreateClientOutputPort
    {
        Task Handler(GetClientDTO cliente);
    }
}
