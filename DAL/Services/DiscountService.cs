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
            _discountRepository.Add(discount);
            _unitOfWork.Commit();
            return discount;
        }

        public IEnumerable<Discount> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _discountRepository.GetMulti(x => x.Name.Contains(keyword) || x.Code.Contains(keyword));
            else
                return _discountRepository.GetAll();
        }

        public Discount GetById(int id)
        {
            var discount =_discountRepository.GetSingleById(id);
            return discount;
        }

        public void Update(Discount discount)
        {
            var currenDiscount = _discountRepository.GetSingleById(discount.Id);

            currenDiscount.Name = discount.Name;
            currenDiscount.Code = discount.Code;
            currenDiscount.DiscountPercent = discount.DiscountPercent;
            currenDiscount.ConditionPrice = discount.ConditionPrice;
            currenDiscount.StartDate = discount.StartDate;
            currenDiscount.EndDate = discount.EndDate;
            currenDiscount.Status = discount.Status;

            _discountRepository.Update(currenDiscount);
            _unitOfWork.Commit();
        }

        public void Delete(int id)
        {
            Discount discount = new Discount();
            discount = _discountRepository.GetSingleById(id);

            _discountRepository.Delete(discount);
            _unitOfWork.Commit();
        }
    }
}
