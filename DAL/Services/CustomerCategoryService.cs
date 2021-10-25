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
    class CustomerCategoryService
    {
        private ICustomerCategoryRepository _customerCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerCategoryService()
        {
            var dbFactory = new DbFactory();
            _customerCategoryRepository = new CustomerCategoryRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }        
        public IEnumerable<CustomerCategory> GetAll()
        {
            return _customerCategoryRepository.GetAll();
        }
        public CustomerCategory Add(CustomerCategory customerCategory)
        {
            CustomerCategory newCustomerCategory = customerCategory;
            _customerCategoryRepository.Add(newCustomerCategory);
            _unitOfWork.Commit();
            return newCustomerCategory;
        }
        public IEnumerable<CustomerCategory> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _customerCategoryRepository.GetMulti(x => x.Name.Contains(keyword));
            }
            else
            {
                return _customerCategoryRepository.GetAll();
            }

        }
        public void Delete(int Id)
        {
            _customerCategoryRepository.Delete(Id);
            _unitOfWork.Commit();
        }
        public void Update(CustomerCategory customerCategory)
        {
            CustomerCategory currentCustomerCategory = new CustomerCategory();
            currentCustomerCategory = _customerCategoryRepository.GetSingleById(customerCategory.Id);
            currentCustomerCategory.Name = customerCategory.Name;
            _customerCategoryRepository.Update(currentCustomerCategory);
            _unitOfWork.Commit();
        }
    }
}
