namespace Dev69Restaurant.DAL.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private RestaurantDbContext dbContext;

        public RestaurantDbContext Init()
        {
            return dbContext ?? (dbContext = new RestaurantDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}