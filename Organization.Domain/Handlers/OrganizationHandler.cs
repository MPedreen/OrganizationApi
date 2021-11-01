using Flunt.Notifications;
using Organization.Domain.Commands;
using Organization.Domain.Commands.Contracts;
using Organization.Domain.Entities;
using Organization.Domain.Handlers.Contracts;
using Organization.Domain.Repositories;

namespace Organization.Domain.Handlers
{
    public class OrganizationHandler : Notifiable, IHandler<CreateOrganizationCommand>
    {
        private readonly IOrganizationRepository _repository;

        public OrganizationHandler(IOrganizationRepository repository)
        {
            _repository = repository;
        }
        public ICommandResult Handle(CreateOrganizationCommand command)
        {
            //Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            //gera a organization
            var organization = new OrganizationItem(command.Title, command.User, command.Date);

            //Salva no banco
            _repository.Create(organization);
        }
    }
}