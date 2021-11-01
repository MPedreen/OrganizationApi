using Organization.Domain.Entities;

namespace Organization.Domain.Repositories
{
    public interface IOrganizationRepository
    {
        void Create(OrganizationItem organization);
        void Update(OrganizationItem organization);
    }
}