namespace Organization.Domain.Commands.Contracts
{
    public interface ICommand
    {
        bool Validate();
    }
}