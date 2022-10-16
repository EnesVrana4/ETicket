using eTicketServices.IServices;
using SharedComponents.ViewModel;
using eTicketData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eTicketData.Entities;

namespace eTicketServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;


        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _repository = userRepository;
            _mapper = mapper;
        }
        public UserViewModel GetUser(string id)
        {
            AspNetUser EntUser = _repository.GetUser(id);
            UserViewModel userViewModel = _mapper.Map<UserViewModel>(EntUser);
            return userViewModel;
        }

        public ICollection<UserViewModel> GetUsers()
        {
            List<UserViewModel> UserViewModelList = new List<UserViewModel>();
            List<AspNetUser> Mylist = (List<AspNetUser>)_repository.GetUsers();
            foreach (var user in Mylist)
            {
                UserViewModel userViewModel = _mapper.Map<UserViewModel>(user);
                UserViewModelList.Add(userViewModel);
            }

            return UserViewModelList;
        }

        public AspNetUser GetByEventId(int id)
        {
            return _repository.GetByEventId(id);
        }

        public UserViewModel UpdateUser(UserViewModel user, string userId)
        {
            var EntUser = _repository.GetUser(userId);

            if (EntUser == null)
                return null;

            EntUser = _mapper.Map(user, EntUser);
            _repository.SaveChanges();

            var userVieModel = _mapper.Map<UserViewModel>(EntUser);

            return userVieModel;

        }

        public string GetCurrentUser() 
        {
            var userId = _repository.GetCurrentUser();

            return userId;
        }

        public UserViewModel UpdateUser(UserViewModel user)
        {
            throw new NotImplementedException();
        }
    }
}

