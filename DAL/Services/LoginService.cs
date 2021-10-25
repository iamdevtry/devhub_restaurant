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
    public class LoginService
    {
        private IUserRepository _userRepository;
        private IRoleRepository _roleRepository;
        private IUserRoleRepository _userRoleRepository;
        private IUnitOfWork _unitOfWork;

        public LoginService()
        {
            var dbFactory = new DbFactory();
            _userRepository = new UserRepository(dbFactory);
            _roleRepository = new RoleRepository(dbFactory);
            _userRoleRepository = new UserRoleRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        public User Login(string username, string password)
        {
            var user = _userRepository.GetSingleByCondition(x => x.Username == username && x.Password == password);
            if(user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        //Get UserRole by username
        public Role GetRoleByUsername(string username)
        {
            var user = _userRoleRepository.GetSingleByCondition(x => x.Username == username);
            var role = _roleRepository.GetSingleById(user.RoleId);
            return role;
        }
    }
}
