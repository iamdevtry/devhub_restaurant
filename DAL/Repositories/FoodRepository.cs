using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;

namespace Dev69Restaurant.DAL.Repositories
{
    public interface IFoodRepository : IRepository<Food>
    {
    }

    public class FoodRepository : RepositoryBase<Food>, IFoodRepository
    {
        public FoodRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}