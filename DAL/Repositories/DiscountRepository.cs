using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;

namespace Dev69Restaurant.DAL.Repositories
{
    public interface IDiscountRepository : IRepository<Discount>
    {
    }

    public class DiscountRepository : RepositoryBase<Discount>, IDiscountRepository
    {
        public DiscountRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}