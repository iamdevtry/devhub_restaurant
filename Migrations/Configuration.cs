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
    }
}
