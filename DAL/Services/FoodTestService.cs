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
    public class FoodTestService
    {
        private IFoodRepository _foodRepository;
        private IUnitOfWork _unitOfWork;

        public FoodTestService()
        {
            var dbFactory = new DbFactory();
            _foodRepository = new FoodRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public IEnumerable<Food> GetAll()
        {
            return _foodRepository.GetAll();
        }
    }
}
