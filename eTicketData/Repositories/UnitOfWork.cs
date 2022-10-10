using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;

namespace eTicketWebApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository User { get; }
        public IRoleRepository Role { get; }

        public IEventRepository Event { get; }

        public UnitOfWork(IUserRepository _user, IRoleRepository _role, IEventRepository _event)
        {

            User = _user;
            Role = _role;
            Event = _event;

        }
    }
}