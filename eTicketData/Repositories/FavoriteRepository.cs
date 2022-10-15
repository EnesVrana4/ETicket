using eTicketData;
using eTicketData.Entities;
using eTicketData.Repositories.Interfaces;
using eTicketData.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eTicketData.Repositories
{
   
    public class FavoriteRepository :  Repository<Favorite>, IFavoriteRepository
    {

        public FavoriteRepository(ApplicationDbContext context, IHttpContextAccessor httpAccessor) : base(context, httpAccessor)
        { }
        private ApplicationDbContext _appContext => (ApplicationDbContext)_context;

        public IEnumerable<Favorite> GetFavoritesByEventId(int eventId)
        {
            var all = _context.Favorites.
                 Where(e =>e.EventId == eventId && e.IsActive == true).ToList();
            return all;
        }

        public IEnumerable<Favorite> GetMyFavorites()
        {
            var all = _context.Favorites.
                Where(e => e.CreatedBy == _context.CurrentUserId && e.IsActive == true).ToList();
            return all;
        }

        public void UpdateFavorite(Favorite favorite, int favoriteId)
        {
            throw new NotImplementedException();
        }
    }
}