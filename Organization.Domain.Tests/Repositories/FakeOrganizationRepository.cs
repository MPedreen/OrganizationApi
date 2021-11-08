using System;
using Organization.Domain.Entities;
using Organization.Domain.Repositories;

namespace Organization.Domain.Tests.Repository
{
    public class FakeOrganizationRepository : IOrganizationRepository
    {
        public void Create(OrganizationItem organization)
        {

        }

        public OrganizationItem GetById(Guid id, string user)
        {
            return new OrganizationItem("Titulo Aqui", "Pedro Ferreira", DateTime.Now);
        }

        public void Update(OrganizationItem organization)
        {

        }
    }
}