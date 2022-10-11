using eTicketData.Repositories.Interfaces;
using eTicketServices.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.Services
{
    public class UnitOfWorkService
    {
        public IUserService User { get; }
        public IRoleService Role { get; }

        public UnitOfWorkService(IUserService _user, IRoleService _role)
        {
            User = _user;
            Role = _role;
        }
    }
}
