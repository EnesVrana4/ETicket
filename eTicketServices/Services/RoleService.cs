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
        private readonly IRoleRepository _repository;
        private readonly AppRoleManager _roleManager;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository roleRepository, IMapper mapper, AppRoleManager roleManager)
        {
            _repository = roleRepository;
            _mapper = mapper;
            _roleManager = roleManager;
        }

        

        public async Task<IEnumerable<AspNetRole>> GetRolesAsync()
        {
            return await _roleManager.Roles.ToListAsync();
        }

       
    }
}
