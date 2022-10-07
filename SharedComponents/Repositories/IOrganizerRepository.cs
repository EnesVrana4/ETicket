using SharedComponents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents.Repositories
{
    public interface IOrganizerRepository
    {
        Task<Orgnaizer> GetByIdAsync(int id);
        Task<Orgnaizer> CreateAsync(Orgnaizer orgnaizer);
        Task<Orgnaizer> UpdateAsync(Orgnaizer orgnaizer);
        Task<Orgnaizer> DeleteAsync(int id);
    }
}
