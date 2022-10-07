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
    public class OrgnaizerService : IOrgnaizerService
    {   
        private readonly IOrganizerRepository _repository;

        public OrgnaizerService(IOrganizerRepository organizerRepository)
        {
            _repository = organizerRepository;
        }

        public async Task<Orgnaizer> CreateAsync(Orgnaizer orgnaizer)
        {
            return await _repository.CreateAsync(orgnaizer);
        }

        public async Task<Orgnaizer> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Orgnaizer> GetByIdAsync(int id)
        {
            return await _repository.DeleteAsync(id);

        }

        public async Task<Orgnaizer> UpdateAsync(Orgnaizer orgnaizer)
        {
            return await _repository.CreateAsync(orgnaizer);

        }
    }
}
