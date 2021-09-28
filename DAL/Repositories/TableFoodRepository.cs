using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.DAL.Repositories
{
    public interface ITableFoodRepository : IRepository<TableFood>
    {

    }
    public class TableFoodRepository : RepositoryBase<TableFood>, ITableFoodRepository
    {
        public TableFoodRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
