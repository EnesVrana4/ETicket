using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedComponents.Services
{
    public interface IAdminService
    {
        Task<bool> CheckPassword();
    }
}
