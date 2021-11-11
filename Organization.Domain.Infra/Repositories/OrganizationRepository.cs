using System;
using System.Collections.Generic;
using Organization.Domain.Entities;
using Organization.Domain.Repositories;

namespace Organization.Domain.Infra.Repositories
{
    public class OrganizationRepository : IOrganizationRepository
    {
        public void Create(OrganizationItem organization)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganizationItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganizationItem> GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganizationItem> GetAllUndone(string user)
        {
            throw new NotImplementedException();
        }

        public OrganizationItem GetById(Guid id, string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrganizationItem> GetByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public void Update(OrganizationItem organization)
        {
            throw new NotImplementedException();
        }
    }
}