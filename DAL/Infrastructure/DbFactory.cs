using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.DAL.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        private RestaurantDbContext dbContext;
        public void Dispose()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        public RestaurantDbContext Init()
        {
            return dbContext ?? (dbContext = new RestaurantDbContext());
        }
    }
}
