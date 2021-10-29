using System;
using Flunt.Notifications;
using Organization.Domain.Commands.Contracts;

namespace Organization.Domain.Commands
{
    public class CreateOrganizationCommand : Notifiable, ICommand
    {
        public CreateOrganizationCommand() { }
        public CreateOrganizationCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public string Title { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }

        public void Validate()
        {

        }
    }
}