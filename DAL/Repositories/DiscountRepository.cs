using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
