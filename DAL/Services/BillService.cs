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
    public class BillService
    {
        private IBillRepository _billRepository;
        private IBillDetailRepository _billDetailRepository;
        private IUnitOfWork _unitOfWork;

        public BillService()
        {
            var dbFactory = new DbFactory();
            _billRepository = new BillRepository(dbFactory);
            _billDetailRepository = new BillDetailRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public Bill Add(Bill bill)
        {
            _billRepository.Add(bill);
            _unitOfWork.Commit();
            return bill;
        }

        public BillDetail Add(BillDetail billDetail)
        {
            _billDetailRepository.Add(billDetail);
            _unitOfWork.Commit();
            return billDetail;
        }

        public IEnumerable<Bill> GetBills()
        {
            return _billRepository.GetAll();
        }

        public IEnumerable<Bill> GetBills(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _billRepository.GetMulti(x=>x.TableFood.Name.Contains(keyword) || x.CreatedBy.Contains(keyword));
            else
                return _billRepository.GetAll();
        }

        public Bill GetBillById(int id)
        {
            return _billRepository.GetSingleById(id);
        }

        public IEnumerable<BillDetail> GetBillDetails()
        {
            return _billDetailRepository.GetAll();
        }

        public IEnumerable<BillDetail> GetBillByBillId(int id)
        {
            if (!string.IsNullOrEmpty(id+""))
                return _billDetailRepository.GetMulti(x => x.BillId == id);
            else
                return _billDetailRepository.GetAll();
        }

    }
}
