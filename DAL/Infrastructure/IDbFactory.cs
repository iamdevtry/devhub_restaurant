using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.DAL.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        RestaurantDbContext Init();
    }
}
