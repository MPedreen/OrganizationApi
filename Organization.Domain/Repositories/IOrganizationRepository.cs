using System;
using System.Collections.Generic;
using Organization.Domain.Entities;

namespace Organization.Domain.Repositories
{
    public interface IOrganizationRepository
    {
        void Create(OrganizationItem organization);
        void Update(OrganizationItem organization);
        OrganizationItem GetById(Guid id, string user);
        IEnumerable<OrganizationItem> GetAll(string user);
        IEnumerable<OrganizationItem> GetAllDone(string user);
        IEnumerable<OrganizationItem> GetAllUndone(string user);
        IEnumerable<OrganizationItem> GetByPeriod(string user, DateTime date, bool done);
    }
}