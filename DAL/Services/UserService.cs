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
    public class UserService
    {
        private IUserRepository _userRepository;
        private IRoleRepository _roleRepository;
        private IUserRoleRepository _userRoleRepository;
        private IUnitOfWork _unitOfWork;

        public UserService()
        {
            var dbFactory = new DbFactory();
            _userRepository = new UserRepository(dbFactory);
            _roleRepository = new RoleRepository(dbFactory);
            _userRoleRepository = new UserRoleRepository(dbFactory);
            _unitOfWork = new UnitOfWork(dbFactory);
        }

        //Add a new User 
        public User Add(User user)
        {
            User newUser = user;
            _userRepository.Add(newUser);
            _unitOfWork.Commit();

            return newUser;
        }

        //Get all users
        public IEnumerable<User> GetAll()
        {
            return _userRepository.GetAll();
        }

        //Get all users 
        public IEnumerable<User> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _userRepository.GetMulti(x => x.FullName.Contains(keyword) || x.Username.Contains(keyword));
            else
                return _userRepository.GetAll();
        }

        //Get info user
        public User GetInfo(User user)
        {
            return _userRepository.GetSingleByCondition(x=>x.Username==user.Username);
        }

        //Get info user
        public void Delete(string username)
        {
            User user = new User();
            user = _userRepository.GetSingleByCondition(x=>x.Username==username);

            _userRepository.Delete(user);
            _unitOfWork.Commit();
        }

        //Update user
        public void Update(User user)
        {
            var currentUser = _userRepository.GetSingleByCondition(x => x.Username == user.Username);

            currentUser.DisplayName = user.DisplayName;
            currentUser.FullName = user.FullName;
            currentUser.Password = user.Password;
            currentUser.Status = user.Status;


            _userRepository.Update(currentUser);
            _unitOfWork.Commit();
        }

        //Check username exist
        public bool CheckExist(string username)
        {
            var result = _userRepository.GetSingleByCondition(x => x.Username == username);
            if (result == null)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        //Get all Roles
        public IEnumerable<Role> GetAllRole()
        {
            return _roleRepository.GetAll();
        }

        //Add user into roles user
        public void AddUserIntoUserRole(string username, int roleId)
        {
            UserRole userRole = new UserRole();
            userRole.Username = username;
            userRole.RoleId = roleId;
            _userRoleRepository.Add(userRole);
            _unitOfWork.Commit();

        }
    }
}
