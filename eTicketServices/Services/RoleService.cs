using AutoMapper;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using eTicketServices.Repositories;
using Microsoft.EntityFrameworkCore;
using SharedComponents.ViewModel;

namespace eTicketServices.Services
{
    public class RoleService : IRoleService
    {
        private readonly IUserRepository _repository;
        private readonly AppRoleManager _roleManager;
        private readonly IMapper _mapper;

        public RoleService(IUserRepository userRepository, IMapper mapper, AppRoleManager roleManager)
        {
            _repository = userRepository;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        public async Task<IEnumerable<AspNetRole>> GetRolesAsync()
        {
            return await _roleManager.Roles.ToListAsync();
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
