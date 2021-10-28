using System;

namespace Organization.Domain.Entities
{
    public class OrganizationItem : Entity
    {
        public string Title { get; private set; }
        public bool Done { get; private set; }
        public DateTime Date { get; private set; }
        public string User { get; private set; }
        //referencia do usuario
    }
}