using Organization.Domain.Commands.Contracts;

namespace Organization.Domain.Handlers.Contracts
{
    public interface IHandler<T> where T : ICommand
    {

    }
}