using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Organization.Domain.Commands.Contracts
{
    public class MarkOrganizationAsDoneCommand : Notifiable, ICommand
    {
        public MarkOrganizationAsDoneCommand() { }

        public MarkOrganizationAsDoneCommand(Guid id, string user)
        {
            Id = id;
            User = user;
        }

        public Guid Id { get; set; }
        public string User { get; set; }
        public void Validate()
        {
            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(User, 6, "User", "Usuário inválido!")
            );
        }
    }
}