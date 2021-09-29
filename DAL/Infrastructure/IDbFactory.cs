using System;

namespace Dev69Restaurant.DAL.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        RestaurantDbContext Init();
    }
}
