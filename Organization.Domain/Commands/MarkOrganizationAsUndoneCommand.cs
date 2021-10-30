using System;
using Flunt.Notifications;
using Flunt.Validations;

namespace Organization.Domain.Commands.Contracts
{
    public class MarkOrganizationAsUnDoneCommand : Notifiable, ICommand
    {
        public MarkOrganizationAsUnDoneCommand() { }

        public MarkOrganizationAsUnDoneCommand(Guid id, string user)
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