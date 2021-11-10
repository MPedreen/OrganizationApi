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
    }
}