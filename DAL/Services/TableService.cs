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
    }
}
