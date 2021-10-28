using System;

namespace Organization.Domain.Entities
{
    public class OrganizationItem : Entity
    {
        public OrganizationItem(string title, string user, DateTime date)
        {
            Title = title;
            Done = false;
            //false pq a tarefa nunca começa ja concluida
            Date = date;
            User = user;
        }

        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }
        //referencia do usuario

        public void MarkAsDone()
        {
            Done = true;
        }
        public void MarkAsUnDone()
        {
            Done = false;
        }
        public void UpdateTitle(string title)
        {
            Title = title;
        }
    }
}