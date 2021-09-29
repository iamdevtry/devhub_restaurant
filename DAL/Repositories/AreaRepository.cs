using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;

namespace Dev69Restaurant.DAL.Repositories
{
    public interface IAreaRepository : IRepository<Area>
    {
    }

    public class AreaRepository : RepositoryBase<Area>, IAreaRepository
    {
        public AreaRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}