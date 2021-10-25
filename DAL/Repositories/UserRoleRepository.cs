using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;

namespace Dev69Restaurant.DAL.Repositories
{
    public interface IUserRoleRepository : IRepository<UserRole>
    {
    }

    public class UserRoleRepository : RepositoryBase<UserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}