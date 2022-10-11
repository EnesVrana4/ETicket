using eTicketData.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketServices.IServices
{
    public interface IUnitOfWorkService
    {
        IUserService User { get; }
        IRoleService Role { get; }
    }
}
