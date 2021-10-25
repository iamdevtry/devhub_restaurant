using Dev69Restaurant.DAL.Infrastructure;
using Dev69Restaurant.DAL.Repositories;
using Dev69Restaurant.DTO.Entities;
using Dev69Restaurant.GUI.ManageCustomer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev69Restaurant.DAL.Services
{
    public class CustomerService
    {
        
        private ICustomerRepository _customerRepository;
        private ICustomerCategoryRepository _customerCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public CustomerService()
        {
            var dbFactory = new DbFactory();
            _customerRepository = new CustomerRepository(dbFactory);
            _customerCategoryRepository = new CustomerCategoryRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }
        //Get all Customer
        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
        public IEnumerable<Customer> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _customerRepository.GetMulti(x=> x.Name.Contains(keyword));
            }
            else 
            {
                return _customerRepository.GetAll();
            }
            
        }
        public Customer Add(Customer customer)
        {
            Customer newCus = customer;
            _customerRepository.Add(newCus);
            _unitOfWork.Commit();
            return newCus;
        }
        public void  Delete(int Id)
        {
            _customerRepository.Delete(Id);
            _unitOfWork.Commit();
        }
      
        public IEnumerable<CustomerCategory> GetCustomerCategory()
        {
            return _customerCategoryRepository.GetAll();
            
        }


    }
}
