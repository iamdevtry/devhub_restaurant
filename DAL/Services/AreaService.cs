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
    class AreaService
    {
        private IAreaRepository _areaRepository;
        private IUnitOfWork _unitOfWork;
        public AreaService()
        {
            var dbFactory = new DbFactory();
            _areaRepository = new AreaRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }
        public IEnumerable<Area> GetAll()
        {
            return _areaRepository.GetAll();
        }
        public Area Add(Area area)
        {
            Area newArea = area;
            _areaRepository.Add(newArea);
            _unitOfWork.Commit();
            return newArea;
        }
        public void Delete(int Id)
        {
            _areaRepository.Delete(Id);
            _unitOfWork.Commit();
        }
        public void Update(Area area)
        {
            Area currentArea = new Area();
            currentArea = _areaRepository.GetSingleById(area.Id);
            currentArea.Name = area.Name;
            _areaRepository.Update(currentArea);
            _unitOfWork.Commit();
        }
        public IEnumerable<Area> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
            {
                return _areaRepository.GetMulti(x => x.Name.Contains(keyword));
            }
            else
            {
                return _areaRepository.GetAll();
            }

        }
    }
   
}
