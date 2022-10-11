using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;
using Microsoft.AspNetCore.Http;

namespace eTicketData.Repositories
{
   
    public class FavoriteRepository :  Repository<Favorite>, IFavoriteRepository
    {

        public FavoriteRepository(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context, httpAccessor)
        { }
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        //public void Update(Event entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}