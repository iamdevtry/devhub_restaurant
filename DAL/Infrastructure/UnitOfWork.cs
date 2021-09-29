namespace Dev69Restaurant.DAL.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        public RestaurantDbContext DataContext
        {
            get;
            set;
        }

        public UnitOfWork(DbFactory dbFactory)
        {
            DataContext = dbFactory.Init();
        }

        public UnitOfWork()
        {
            DataContext = new RestaurantDbContext();
        }

        public void Commit()
        {
            DataContext.SaveChanges();
        }
    }
}