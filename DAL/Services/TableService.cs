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
    public class TableService
    {
        private ITableFoodRepository _tableFoodRepository;
        private IUnitOfWork _unitOfWork;

        public TableService()
        {
            var dbFactory = new DbFactory();
            _tableFoodRepository = new TableFoodRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public IEnumerable<TableFood> GetAll()
        {
            return _tableFoodRepository.GetAll();
        }

        public IEnumerable<TableFood> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _tableFoodRepository.GetMulti(x => x.Name.Contains(keyword));
            }
            else
            {
                return _tableFoodRepository.GetAll();
            }
        }

        public TableFood Find(string name)
        {
            return _tableFoodRepository.GetSingleByCondition(x=>x.Name==name);
        }

        public TableFood Add(TableFood tableFood)
        {
            TableFood newTable = tableFood;
            _tableFoodRepository.Add(newTable);
            _unitOfWork.Commit();
            return newTable;
        }
        public void Delete(int Id)
        {
            _tableFoodRepository.Delete(Id);
            _unitOfWork.Commit();
        }
        public void Update(TableFood tableFood)
        {
            var currentTable = _tableFoodRepository.GetSingleByCondition(x => x.Id == tableFood.Id);
            currentTable.Name = tableFood.Name;
            _tableFoodRepository.Update(currentTable);
            _unitOfWork.Commit();

        }
    }
}
