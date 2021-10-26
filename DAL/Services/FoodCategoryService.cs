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
    class FoodCategoryService
    {
        private IFoodCategoryRepository _foodCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public FoodCategoryService()
        {
            var dbFactory = new DbFactory();
            _foodCategoryRepository = new FoodCategoryRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }
        public FoodCategory Add(FoodCategory foodCategory)
        {
            FoodCategory newFoodCategory = foodCategory;
            _foodCategoryRepository.Add(newFoodCategory);
            _unitOfWork.Commit();
            return newFoodCategory;
        }
        public IEnumerable<FoodCategory> GetAll()
        {
            return _foodCategoryRepository.GetAll();
        }

        public IEnumerable<FoodCategory> GetAll(string keywork)
        {
            if (!string.IsNullOrEmpty(keywork))
            {
                return _foodCategoryRepository.GetMulti(x => x.Name.Contains(keywork));
            }
            else
            {
                return _foodCategoryRepository.GetAll();
            }
        }

        public void Delete(int id)
        {
            _foodCategoryRepository.Delete(id);
            _unitOfWork.Commit();
        }
        public void Update(FoodCategory foodCategory)
        {
            FoodCategory currentFoodCategory = new FoodCategory();
            currentFoodCategory = _foodCategoryRepository.GetSingleById(foodCategory.Id);
            currentFoodCategory.Name = foodCategory.Name;
            currentFoodCategory.Description = foodCategory.Description;
            currentFoodCategory.Status = foodCategory.Status;
            currentFoodCategory.UpdatedDate = foodCategory.UpdatedDate;

            _foodCategoryRepository.Update(currentFoodCategory);
            _unitOfWork.Commit();
        }
    }
}
