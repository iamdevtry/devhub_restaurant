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
        private IUnitOfWork _unitOfWork;

        public UserService()
        {
            var dbFactory = new DbFactory();
            _userRepository = new UserRepository(dbFactory);
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

        //Get info user
        public User GetInfo(User user)
        {
            return _userRepository.GetSingleByCondition(x=>x.Username==user.Username);
        }

        //Update user
        public void Update(User user)
        {
            var currentUser = _userRepository.GetSingleByCondition(x => x.Username == user.Username);

            currentUser.DisplayName = user.DisplayName;
            currentUser.FullName = user.FullName;
            currentUser.Password = user.Password;
            currentUser.Address = user.Address;
            currentUser.Phone = user.Phone;
            currentUser.Email = user.Email;
            currentUser.Status = user.Status;


            _userRepository.Update(currentUser);
            _unitOfWork.Commit();
        }
    }
}
