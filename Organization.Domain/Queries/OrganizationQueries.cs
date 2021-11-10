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
    }
}