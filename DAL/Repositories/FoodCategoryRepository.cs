using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;

namespace Dev69Restaurant.DAL.Repositories
{
    public interface IFoodCategoryRepository : IRepository<FoodCategory>
    {
    }

    public class FoodCategoryRepository : RepositoryBase<FoodCategory>, IFoodCategoryRepository
    {
        public FoodCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}