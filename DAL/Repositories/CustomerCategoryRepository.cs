using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
