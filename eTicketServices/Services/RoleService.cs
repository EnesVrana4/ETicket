using AutoMapper;
using eTicketData.Entities;
using Microsoft.AspNetCore.Identity;
using SharedComponents.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;

namespace eTicketServices.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public RoleService(IUserRepository userRepository, IMapper mapper)
        {
            _repository = userRepository;
            _mapper = mapper;
        }

        public ICollection<IdentityRole> GetRoles()
        {
            throw new NotImplementedException();
        }

        public ICollection<RoleViewModel> GetUsers()
        {
            List<RoleViewModel> RoleViewModelList = new List<RoleViewModel>();
            List<AspNetUser> Mylist = (List<AspNetUser>)_repository.GetUsers();
            foreach (var user in Mylist)
            {
                RoleViewModel roleViewModel = _mapper.Map<RoleViewModel>(user);
                RoleViewModelList.Add(roleViewModel);
            }

            return RoleViewModelList;
        }
    }
}
