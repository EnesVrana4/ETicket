using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;
using Microsoft.AspNetCore.Http;

namespace eTicketData.Repositories
{

    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        public CategoryRepository(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context, httpAccessor)
        { }
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public IEnumerable<Category> GetByEventId(int eventId)
        {
            var all = _context.Categorys.
                 Where(e =>e.IsActive == true && e.EventId==eventId).ToList();
            return all;
        }
    }
}