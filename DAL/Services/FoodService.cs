using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DAL.Repositories;
using Dev69Restaurant.DTO.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.DAL.Services
{
    class FoodService
    {
        private IFoodRepository _foodRepository;
        private IFoodCategoryRepository _foodCategoryRepository;

        private IUnitOfWork _unitOfWork;
        public FoodService()
        {
            var dbFactory = new DbFactory();
            _foodRepository = new FoodRepository(dbFactory);
            _foodCategoryRepository = new FoodCategoryRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }
        public Food Add(Food food)
        {
            Food newFood = food;
            _foodRepository.Add(newFood);
            _unitOfWork.Commit();
            return newFood;
        }

        public IEnumerable<Food> GetAll()
        {
            return _foodRepository.GetAll();
        }

        public IEnumerable<FoodCategory> GetFoodCategory()
        {
            return _foodCategoryRepository.GetAll();
        }

        public IEnumerable<Food> GetAll(string keywork)
        {
            if (!string.IsNullOrEmpty(keywork))
            {
                return _foodRepository.GetMulti(x => x.Name.Contains(keywork));
            }
            else
            {
                return _foodRepository.GetAll();
            }
        }

        public Food Find(int id)
        {
            return _foodRepository.GetSingleById(id);
        }

        public void  Delete(int id)
        {
            _foodRepository.Delete(id);
            _unitOfWork.Commit();
        }

        public void Update(Food food)
        {
            Food currentFood = new Food();
            currentFood = _foodRepository.GetSingleById(food.Id);
            currentFood.Name = food.Name;
            currentFood.Price = food.Price;
            currentFood.PromotionPrice = food.PromotionPrice;
            currentFood.CategoryId = food.CategoryId;
            currentFood.Status = food.Status;
            currentFood.UpdatedDate = food.UpdatedDate;
            currentFood.Image = food.Image;
            
            _foodRepository.Update(currentFood);
            _unitOfWork.Commit();
        }
    }
}
