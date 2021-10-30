namespace Dev69Restaurant.Migrations
{
    using Dev69Restaurant.DTO.Entities;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Dev69Restaurant.RestaurantDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Dev69Restaurant.RestaurantDbContext context)
        {
            CreateFoodCategorySample(context);
            CreateFoodSample(context);
            CreateRoles(context);
            CreateUsers(context);
            CreateUserRoles(context);
        }

        private void CreateFoodCategorySample(RestaurantDbContext context)
        {
            if (context.FoodCategories.Count() == 0)
            {
                List<FoodCategory> listFoodCategories = new List<FoodCategory>()
            {
                new FoodCategory() { Name="Thức uống",Status=true },
                 new FoodCategory() { Name="Món chính",Status=true },
                  new FoodCategory() { Name="Điểm tâm",Status=true },
                   new FoodCategory() { Name="Combo",Status=true }
            };
                context.FoodCategories.AddRange(listFoodCategories);
                context.SaveChanges();
            }
        }
        private void CreateFoodSample(RestaurantDbContext context)
        {
            if (context.Foods.Count() == 0)
            {
                List<Food> listFoods = new List<Food>()
            {
                new Food() { Name="Bánh Mì",Price=30000,CategoryId=1,Status=true },
                 new Food() { Name="Sữa bò",Price=35000,CategoryId=2,Status=true },
                  new Food() { Name="Gà rán",Price=90000,CategoryId=3,Status=true },
                   new Food() { Name="Hamburger",Price=45000,CategoryId=4,Status=true }
            };
                context.Foods.AddRange(listFoods);
                context.SaveChanges();
            }
        }

        private void CreateRoles(RestaurantDbContext context)
        {
            if (context.Roles.Count() == 0)
            {
                List<Role> listRoles = new List<Role>()
            {
                new Role() { Name="Quản lý",ShortName="admin"},
                 new Role() { Name="Nhân viên",ShortName="staff"}
            };
                context.Roles.AddRange(listRoles);
                context.SaveChanges();
            }
        }

        private void CreateUsers(RestaurantDbContext context)
        {
            if (context.Users.Count() == 0)
            {
                List<User> listUsers = new List<User>()
            {
                new User() { Username="admin", Password="25f9e794323b453885f5181f1b624d0b",DisplayName="Administrator",FullName="Quản lý", Status = true},
                 new User() { Username="staff", Password="25f9e794323b453885f5181f1b624d0b",DisplayName="Staff NV",FullName="Nhân viên", Status = true}
            };
                context.Users.AddRange(listUsers);
                context.SaveChanges();
            }
        }

        private void CreateUserRoles(RestaurantDbContext context)
        {
            if (context.UserRoles.Count() == 0)
            {
                List<UserRole> listUserRoles = new List<UserRole>()
            {
                new UserRole() { Username="admin", RoleId=1},
                 new UserRole() { Username="staff", RoleId=2}
            };
                context.UserRoles.AddRange(listUserRoles);
                context.SaveChanges();
            }
        }
    }
}
