using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Organization.Domain.Entities;
using Organization.Domain.Infra.Contexts;
using Organization.Domain.Queries;
using Organization.Domain.Repositories;

namespace Organization.Domain.Infra.Repositories
{
    public class OrganizationRepository : IOrganizationRepository
    {
        private readonly DataContext _context;

        public OrganizationRepository(DataContext context)
        {
            _context = context;
        }

        public void Create(OrganizationItem organization)
        {
            _context.Organizations.Add(organization);
            _context.SaveChanges();
        }

        public IEnumerable<OrganizationItem> GetAll(string user)
        {
            return _context.Organizations.AsNoTracking().Where(OrganizationQueries.GetAll(user)).OrderBy(x => x.Date);
        }

        public IEnumerable<OrganizationItem> GetAllDone(string user)
        {
            return _context.Organizations.AsNoTracking().Where(OrganizationQueries.GetAllDone(user)).OrderBy(x => x.Date);
        }

        public IEnumerable<OrganizationItem> GetAllUndone(string user)
        {
            return _context.Organizations.AsNoTracking().Where(OrganizationQueries.GetAllUnDone(user)).OrderBy(x => x.Date);
        }

        public OrganizationItem GetById(Guid id, string user)
        {
            return _context.Organizations.FirstOrDefault(OrganizationQueries.GetById(id, user));
        }

        public IEnumerable<OrganizationItem> GetByPeriod(string user, DateTime date, bool done)
        {
            return _context.Organizations.AsNoTracking().Where(OrganizationQueries.GetByPeriod(user, date, done)).OrderBy(x => x.Date);
        }

        public void Update(OrganizationItem organization)
        {
            _context.Entry(organization).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}