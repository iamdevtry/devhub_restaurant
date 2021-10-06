using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DAL.Repositories;
using Dev69Restaurant.DTO.Entities;
using System.Collections.Generic;

namespace Dev69Restaurant.DAL.Services
{
    public class DiscountService
    {
        private IDiscountRepository _discountRepository;
        private IUnitOfWork _unitOfWork;

        public DiscountService()
        {
            var dbFactory = new DbFactory();
            _discountRepository = new DiscountRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public Discount Add(Discount discount)
        {
            Discount newDis = discount;
            _discountRepository.Add(newDis);
            _unitOfWork.Commit();

            return newDis;
        }

        public IEnumerable<Discount> GetAll()
        {
            return _discountRepository.GetAll();
        }
    }
}