using System;
using Organization.Domain.Entities;

namespace Organization.Domain.Repositories
{
    public interface IOrganizationRepository
    {
        void Create(OrganizationItem organization);
        void Update(OrganizationItem organization);
        OrganizationItem GetById(Guid id, string user);
    }
}