using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;

namespace Dev69Restaurant.DAL.Repositories
{
    public interface ICustomerCategoryRepository : IRepository<CustomerCategory>
    {
    }

    public class CustomerCategoryRepository : RepositoryBase<CustomerCategory>, ICustomerCategoryRepository
    {
        public CustomerCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}