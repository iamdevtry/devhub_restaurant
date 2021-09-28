using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
