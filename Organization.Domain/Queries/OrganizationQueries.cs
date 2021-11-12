using System;
using System.Linq.Expressions;
using Organization.Domain.Entities;

namespace Organization.Domain.Queries
{
    public static class OrganizationQueries
    {
        public static Expression<Func<OrganizationItem, bool>> GetAll(string user)
        {
            return x => x.User == user;
        }

        public static Expression<Func<OrganizationItem, bool>> GetAllDone(string user)
        {
            return x => x.User == user && x.Done;
            //ou
            //return x => x.User == user && x.Done == true;
        }

        public static Expression<Func<OrganizationItem, bool>> GetAllUnDone(string user)
        {
            return x => x.User == user && x.Done == false;
        }

        public static Expression<Func<OrganizationItem, bool>> GetById(Guid id, string user)
        {
            return x => x.Id == id && x.User == user;
        }

        public static Expression<Func<OrganizationItem, bool>> GetByPeriod(string user, DateTime date, bool done)
        {
            return x =>
                x.User == user &&
                x.Done == done &&
                x.Date.Date == date.Date;
        }
    }
}