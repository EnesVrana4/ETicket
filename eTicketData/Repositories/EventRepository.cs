using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;

namespace eTicketWebApp.Repositories
{

    public class EventRepository :  Repository<Event>, IEventRepository
    {

        public EventRepository(ApplicationDbContext context) : base(context)
        { }
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;


    }
}