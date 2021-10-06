using Dev69Restaurant.DTO.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace Dev69Restaurant
{
    public class RestaurantDbContext : DbContext
    {

        public RestaurantDbContext() : base("RestaurantDev69")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Area> Areas { set; get; }
        public DbSet<Bill> Bills { set; get; }
        public DbSet<BillDetail> BillDetails { set; get; }
        public DbSet<Customer> Customers { set; get; }
        public DbSet<CustomerCategory> CustomerCategories { set; get; }
        public DbSet<Discount> Discounts { set; get; }
        public DbSet<Food> Foods { set; get; }
        public DbSet<FoodCategory> FoodCategories { set; get; }
        public DbSet<TableFood> TableFoods { set; get; }
        public DbSet<VAT> VATs { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<UserRole> UserRoles { set; get; }

    }


}