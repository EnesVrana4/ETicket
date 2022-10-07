using eTicketServices.IServices;
using SharedComponents.Models;
using SharedComponents.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository userRepository)
        {
            _repository = userRepository;
        }

        public async Task<User> CreateAsync(User user)
        {
            return await _repository.CreateAsync(user);
        }

        public async Task<User> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _repository.DeleteAsync(id);

        }

        public async Task<User> UpdateAsync(User user)
        {
            return await _repository.CreateAsync(user);

        }
    }
}
